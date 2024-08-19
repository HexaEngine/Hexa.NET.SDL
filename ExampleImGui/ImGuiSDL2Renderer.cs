#define SDL_VERSION_ATLEAST_2_0_19
namespace ExampleImGui
{
    using Hexa.NET.ImGui;
    using Hexa.NET.SDL2;
    using System.Diagnostics;
    using System.Numerics;
    using System.Runtime.InteropServices;
    using static Hexa.NET.SDL2.SDL;
    using ImDrawIdx = ushort;

    public unsafe class ImGuiSDL2Renderer
    {
        private struct RendererData
        {
            public SDLRenderer* Renderer;       // Main viewport's renderer
            public SDLTexture* FontTexture;
        };

        private static RendererData* GetBackendData()
        {
            return !ImGui.GetCurrentContext().IsNull ? (RendererData*)ImGui.GetIO().BackendRendererUserData : null;
        }

        public static bool Init(SDLRenderer* renderer)
        {
            ImGuiIOPtr io = ImGui.GetIO();
            Debug.Assert(io.BackendRendererUserData == null, "Already initialized a renderer backend!");
            Debug.Assert(renderer != null, "SDL_Renderer not initialized!");

            RendererData* bd = AllocT<RendererData>();
            ZeroMemoryT(bd);
            io.BackendRendererUserData = bd;
            io.BackendRendererName = "imgui_impl_sdl2renderer".ToUTF8Ptr();
            io.BackendFlags |= ImGuiBackendFlags.RendererHasVtxOffset;

            bd->Renderer = renderer;

            CreateDeviceObjects();

            return true;
        }

        public static void Shutdown()
        {
            RendererData* bd = GetBackendData();
            Debug.Assert(bd != null, "No renderer backend to shutdown, or already shutdown?");
            ImGuiIOPtr io = ImGui.GetIO();

            DestroyDeviceObjects();

            io.BackendRendererUserData = null;
            io.BackendRendererName = null;
            io.BackendFlags &= ~ImGuiBackendFlags.RendererHasVtxOffset;
            Free(bd);
        }

        public static void SetupRenderState(SDLRenderer* renderer)
        {
            RenderSetViewport(renderer, null);
            RenderSetClipRect(renderer, null);
        }

        public static void NewFrame()
        {
            RendererData* bd = GetBackendData();
            Debug.Assert(bd != null, "Context or backend not initialized! Did you call ImGui_ImplSDLRenderer2_Init()?");

            if (bd->FontTexture == null)
                CreateDeviceObjects();
        }

        private struct BackupSDLRendererState
        {
            public SDLRect Viewport;
            public bool ClipEnabled;
            public SDLRect ClipRect;
        };

        public static void RenderDrawData(ImDrawData* draw_data, SDLRenderer* renderer)
        {
            // If there's a scale factor set by the user, use that instead
            // If the user has specified a scale factor to SDL_Renderer already via SDL_RenderSetScale(), SDL will scale whatever we pass
            // to SDL_RenderGeometryRaw() by that scale factor. In that case we don't want to be also scaling it ourselves here.
            float rsx = 1.0f;
            float rsy = 1.0f;
            RenderGetScale(renderer, &rsx, &rsy);
            Vector2 render_scale;
            render_scale.X = (rsx == 1.0f) ? draw_data->FramebufferScale.X : 1.0f;
            render_scale.Y = (rsy == 1.0f) ? draw_data->FramebufferScale.Y : 1.0f;

            // Avoid rendering when minimized, scale coordinates for retina displays (screen coordinates != framebuffer coordinates)
            int fb_width = (int)(draw_data->DisplaySize.X * render_scale.X);
            int fb_height = (int)(draw_data->DisplaySize.Y * render_scale.Y);
            if (fb_width == 0 || fb_height == 0)
                return;

            // Backup SDL_Renderer state that will be modified to restore it afterwards

            BackupSDLRendererState old = default;
            old.ClipEnabled = RenderIsClipEnabled(renderer) == SDLBool.True;
            RenderGetViewport(renderer, &old.Viewport);
            RenderGetClipRect(renderer, &old.ClipRect);

            // Will project scissor/clipping rectangles into framebuffer space
            Vector2 clip_off = draw_data->DisplayPos;         // (0,0) unless using multi-viewports
            Vector2 clip_scale = render_scale;

            // Render command lists
            SetupRenderState(renderer);
            for (int n = 0; n < draw_data->CmdListsCount; n++)
            {
                ImDrawList* cmd_list = draw_data->CmdLists[n];
                ImDrawVert* vtx_buffer = cmd_list->VtxBuffer.Data;
                ImDrawIdx* idx_buffer = cmd_list->IdxBuffer.Data;

                for (int cmd_i = 0; cmd_i < cmd_list->CmdBuffer.Size; cmd_i++)
                {
                    ImDrawCmd pcmd = cmd_list->CmdBuffer[cmd_i];
                    if (pcmd.UserCallback != null)
                    {
                        // User callback, registered via ImDrawList::AddCallback()
                        // (ImDrawCallback_ResetRenderState is a special callback value used by the user to request the renderer to reset render state.)
                        if (pcmd.UserCallback == (void*)unchecked((nuint)(-8)))
                            SetupRenderState(renderer);
                        else
                            ((delegate*<ImDrawList*, ImDrawCmd*, void>)pcmd.UserCallback)(cmd_list, &pcmd);
                    }
                    else
                    {
                        // Project scissor/clipping rectangles into framebuffer space
                        Vector2 clip_min = new((pcmd.ClipRect.X - clip_off.X) * clip_scale.X, (pcmd.ClipRect.Y - clip_off.Y) * clip_scale.Y);
                        Vector2 clip_max = new((pcmd.ClipRect.Z - clip_off.X) * clip_scale.X, (pcmd.ClipRect.W - clip_off.Y) * clip_scale.Y);
                        if (clip_min.X < 0.0f) { clip_min.X = 0.0f; }
                        if (clip_min.Y < 0.0f) { clip_min.Y = 0.0f; }
                        if (clip_max.X > fb_width) { clip_max.X = fb_width; }
                        if (clip_max.Y > fb_height) { clip_max.Y = fb_height; }
                        if (clip_max.X <= clip_min.X || clip_max.Y <= clip_min.Y)
                            continue;

                        SDLRect r = new((int)(clip_min.X), (int)(clip_min.Y), (int)(clip_max.X - clip_min.X), (int)(clip_max.Y - clip_min.Y));
                        RenderSetClipRect(renderer, &r);

                        float* xy = (float*)(void*)((byte*)(vtx_buffer + pcmd.VtxOffset) + posOffset);
                        float* uv = (float*)(void*)((byte*)(vtx_buffer + pcmd.VtxOffset) + uvOffset);
#if SDL_VERSION_ATLEAST_2_0_19
                        SDLColor* color = (SDLColor*)(void*)((byte*)(vtx_buffer + pcmd.VtxOffset) + colOffset); // SDL 2.0.19+
#else
                        int* color = (int*)(void*)((byte*)(vtx_buffer + pcmd.VtxOffset) + colOffset); // SDL 2.0.17 and 2.0.18
#endif

                        // Bind texture, Draw
                        SDLTexture* tex = (SDLTexture*)pcmd.GetTexID().Handle;
                        RenderGeometryRaw(renderer, tex,
                            xy, sizeof(ImDrawVert),
                            color, sizeof(ImDrawVert),
                            uv, sizeof(ImDrawVert),
                            (int)(cmd_list->VtxBuffer.Size - pcmd.VtxOffset),
                            idx_buffer + pcmd.IdxOffset, (int)pcmd.ElemCount, sizeof(ImDrawIdx));
                    }
                }
            }

            // Restore modified SDL_Renderer state
            RenderSetViewport(renderer, &old.Viewport);
            RenderSetClipRect(renderer, old.ClipEnabled ? &old.ClipRect : null);
        }

        const int posOffset = 0;      // Offset von Pos (erster Member)
        const int uvOffset = 8;       // Offset von Uv (nach Pos, Vector2 = 8 Bytes)
        const int colOffset = 16;     // Offset von Col (nach Uv, Vector2 = 8 Bytes)

        static bool CreateFontsTexture()
        {
            ImGuiIOPtr io = ImGui.GetIO();
            RendererData* bd = GetBackendData();

            // Build texture atlas
            byte* pixels;
            int width, height;
            io.Fonts.GetTexDataAsRGBA32(&pixels, &width, &height);   // Load as RGBA 32-bit (75% of the memory is wasted, but default font is so small) because it is more likely to be compatible with user's existing shaders. If your ImTextureId represent a higher-level concept than just a GL texture id, consider calling GetTexDataAsAlpha8() instead to save on GPU memory.

            // Upload texture to graphics system
            // (Bilinear sampling is required by default. Set 'io.Fonts->Flags |= ImFontAtlasFlags_NoBakedLines' or 'style.AntiAliasedLinesUseTex = false' to allow point/nearest sampling)
            bd->FontTexture = CreateTexture(bd->Renderer, (int)SDLPixelFormatEnum.Abgr8888, (int)SDLTextureAccess.Static, width, height);
            if (bd->FontTexture == null)
            {
                Log("error creating texture");
                return false;
            }
            UpdateTexture(bd->FontTexture, null, pixels, 4 * width);
            SetTextureBlendMode(bd->FontTexture, SDLBlendMode.Blend);
            SetTextureScaleMode(bd->FontTexture, SDLScaleMode.Linear);

            // Store our identifier
            io.Fonts.SetTexID((ImTextureID)(nint)bd->FontTexture);

            return true;
        }

        private static void DestroyFontsTexture()
        {
            ImGuiIOPtr io = ImGui.GetIO();
            RendererData* bd = GetBackendData();
            if (bd->FontTexture != null)
            {
                io.Fonts.SetTexID(0);
                DestroyTexture(bd->FontTexture);
                bd->FontTexture = null;
            }
        }

        private static bool CreateDeviceObjects()
        {
            return CreateFontsTexture();
        }

        private static void DestroyDeviceObjects()
        {
            DestroyFontsTexture();
        }
    }
}