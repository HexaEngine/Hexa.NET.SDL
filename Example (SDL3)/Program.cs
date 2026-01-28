// See https://aka.ms/new-console-template for more information

using Hexa.NET.SDL3;

SDL.SetHint(SDL.SDL_HINT_MOUSE_FOCUS_CLICKTHROUGH, "1");
SDL.Init(SDLInitFlags.Events | SDLInitFlags.Video);

SDLWindowPtr window = SDL.CreateWindow("Test Window", 1280, 720, SDLWindowFlags.Resizable);
if (window.IsNull)
{
    return;
}

uint windowId = SDL.GetWindowID(window);

SDLEvent sdlEvent = default;
bool exiting = false;
while (!exiting)
{
    SDL.PumpEvents();

    while (SDL.PollEvent(ref sdlEvent))
    {
        switch ((SDLEventType)sdlEvent.Type)
        {
            case SDLEventType.Quit:
                exiting = true;
                break;

            case SDLEventType.Terminating:
                exiting = true;
                break;

            case SDLEventType.WindowCloseRequested:
                var windowEvent = sdlEvent.Window;
                if (windowEvent.WindowID == windowId)
                {
                    exiting = true;
                }
                break;
        }
    }
}

SDL.Quit();
