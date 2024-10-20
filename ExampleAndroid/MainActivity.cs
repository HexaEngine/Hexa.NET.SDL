namespace ExampleAndroid
{
    using Android.Content.PM;
    using Android.Runtime;
    using Hexa.NET.SDL2;
    using Hexa.NET.Utilities;
    using System.Runtime.InteropServices;

    [Activity(Label = "ExampleAndroid", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/AppTheme")]
    public unsafe class MainActivity : Activity
    {
        private Thread thread;

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RunOnUiThread(() =>
            {
                SDL.SetHint(SDL.SDL_HINT_MOUSE_FOCUS_CLICKTHROUGH, "1");
                SDL.SetHint(SDL.SDL_HINT_AUTO_UPDATE_JOYSTICKS, "1");
                SDL.SetHint(SDL.SDL_HINT_JOYSTICK_HIDAPI_PS4, "1");//HintJoystickHidapiPS4
                SDL.SetHint(SDL.SDL_HINT_JOYSTICK_HIDAPI_PS4_RUMBLE, "1"); //HintJoystickHidapiPS4Rumble
                SDL.SetHint(SDL.SDL_HINT_JOYSTICK_RAWINPUT, "0");
                SDL.SetHint(SDL.SDL_HINT_WINDOWS_DISABLE_THREAD_NAMING, "1"); //HintWindowsDisableThreadNaming
                SDL.SetHint(SDL.SDL_HINT_MOUSE_NORMAL_SPEED_SCALE, "1");
                SDL.SetHint(SDL.SDL_HINT_MOUSE_AUTO_CAPTURE, "0");
                SDL.SetHint(SDL.SDL_HINT_IME_SHOW_UI, "1");

                SDL.Init(SDL.SDL_INIT_EVENTS + SDL.SDL_INIT_GAMECONTROLLER + SDL.SDL_INIT_HAPTIC + SDL.SDL_INIT_JOYSTICK + SDL.SDL_INIT_SENSOR);

                thread = new Thread(NewMethod);
                thread.Start();
            });
        }

        private static void NewMethod()
        {
            var window = SDL.CreateWindow("Test Window", (int)SDL.SDL_WINDOWPOS_UNDEFINED_MASK, (int)SDL.SDL_WINDOWPOS_UNDEFINED_MASK, 1280, 720, (uint)SDLWindowFlags.Resizable);
            var windowId = SDL.GetWindowID(window);

            SDLRenderer* renderer = SDL.CreateRenderer(window, -1, (uint)SDLRendererFlags.Accelerated);

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

                SDL.RenderClear(renderer);

                SDL.SetRenderTarget(renderer, null);
                SDL.RenderGeometry(renderer, null, verts.Data, verts.Size, null, 0);

                SDL.RenderPresent(renderer);
            }
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            SDL.Quit();
            thread.Join();
        }
    }
}