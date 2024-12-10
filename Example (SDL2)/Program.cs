// See https://aka.ms/new-console-template for more information
using Hexa.NET.SDL2;

unsafe
{
    SDL.SetHint(SDL.SDL_HINT_MOUSE_FOCUS_CLICKTHROUGH, "1");
    SDL.Init(SDL.SDL_INIT_EVENTS | SDL.SDL_INIT_VIDEO);

    var window = SDL.CreateWindow("Test Window", 32, 32, 1280, 720, (uint)SDLWindowFlags.Resizable);
    var windowId = SDL.GetWindowID(window);
    SDL.UpperBlit
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
    }

    SDL.Quit();
}