namespace ExampleImGui
{
    using Hexa.NET.ImGui;
    using Hexa.NET.SDL2;
    using Hexa.NET.Utilities;

    public unsafe class Program
    {
        private readonly static List<EventHook> eventHooks = new();

        public static void AddHook(EventHook hook)
        {
            eventHooks.Add(hook);
        }

        public static void RemoveHook(EventHook hook)
        {
            eventHooks.Remove(hook);
        }

        public delegate bool EventHook(SDLEvent sdlEvent);

        private static void Main(string[] args)
        {
            SDL.SetHint(SDL.SDL_HINT_MOUSE_FOCUS_CLICKTHROUGH, "1");
            SDL.Init(SDL.SDL_INIT_EVENTS | SDL.SDL_INIT_VIDEO);

            var window = SDL.CreateWindow("Test Window", 32, 32, 1280, 720, (uint)(SDLWindowFlags.Resizable | SDLWindowFlags.Shown));
            var windowId = SDL.GetWindowID(window);

            var renderer = SDL.CreateRenderer(window, -1, (uint)(SDLRendererFlags.Accelerated | SDLRendererFlags.Presentvsync | SDLRendererFlags.Targettexture));

            ImGuiContextPtr context = ImGui.CreateContext();
            ImGui.SetCurrentContext(context);
            var io = ImGui.GetIO();
            io.ConfigFlags |= ImGuiConfigFlags.NavEnableKeyboard | ImGuiConfigFlags.NavEnableGamepad | ImGuiConfigFlags.DockingEnable | ImGuiConfigFlags.ViewportsEnable;
            io.ConfigViewportsNoAutoMerge = false;
            io.ConfigViewportsNoTaskBarIcon = false;
            io.ConfigDragClickToInputText = true;

            io.Fonts.AddFontDefault();
            ImGui.StyleColorsDark();

            ImGuiSDL2Platform.InitForSDLRenderer(window, renderer);
            ImGuiSDL2Renderer.Init(renderer);

            Time.Initialize();

            UnsafeList<SDLVertex> verts =
            [
                new(new SDLFPoint( 400, 150 ), new SDLColor( 255, 0, 0, 255 ), new SDLFPoint( 0 ) ),
                new(new SDLFPoint( 200, 450 ), new SDLColor( 0, 0, 255, 255 ), new SDLFPoint( 0 ) ),
                new(new SDLFPoint( 600, 450 ), new SDLColor( 0, 255, 0, 255 ), new SDLFPoint( 0 ) ),
            ];

            SDLEvent sdlEvent = default;
            bool exiting = false;
            while (!exiting)
            {
                SDL.PumpEvents();

                while ((SDLBool)SDL.PollEvent(ref sdlEvent) == SDLBool.True)
                {
                    foreach (var hook in eventHooks)
                    {
                        if (hook(sdlEvent))
                        {
                            continue;
                        }
                    }
                    switch ((SDLEventType)sdlEvent.Type)
                    {
                        case SDLEventType.Quit:
                            exiting = true;
                            break;

                        case SDLEventType.AppTerminating:
                            exiting = true;
                            break;

                        case SDLEventType.Windowevent:
                            var windowEvent = sdlEvent.Window;
                            if (windowEvent.WindowID == windowId)
                            {
                                if ((SDLWindowEventID)windowEvent.Event == SDLWindowEventID.Close)
                                {
                                    exiting = true;
                                }
                            }
                            break;
                    }
                }

                Time.FrameUpdate();

                ImGui.SetCurrentContext(context);
                ImGuiSDL2Platform.NewFrame();
                ImGui.NewFrame();

                ImGui.ShowDemoWindow();

                ImGui.Render();
                ImGui.EndFrame();

                SDL.RenderClear(renderer);

                SDL.SetRenderTarget(renderer, null);
                SDL.RenderGeometry(renderer, null, verts.Data, verts.Size, null, 0);

                ImGuiSDL2Renderer.RenderDrawData(ImGui.GetDrawData(), renderer);

                if ((io.ConfigFlags & ImGuiConfigFlags.ViewportsEnable) != 0)
                {
                    ImGui.UpdatePlatformWindows();
                    ImGui.RenderPlatformWindowsDefault();
                }

                SDL.RenderPresent(renderer);
            }

            SDL.Quit();
        }
    }
}