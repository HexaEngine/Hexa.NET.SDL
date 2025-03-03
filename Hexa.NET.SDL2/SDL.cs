namespace Hexa.NET.SDL2
{
    using HexaGen.Runtime;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    public static class SDLConfig
    {
        public static bool AotStaticLink;
    }

    public static unsafe partial class SDL
    {
        static SDL()
        {
            if (SDLConfig.AotStaticLink)
            {
                InitApi(new NativeLibraryContext(Process.GetCurrentProcess().MainModule!.BaseAddress));
            }
            else
            {
                InitApi(new NativeLibraryContext(LibraryLoader.LoadLibrary(GetLibraryName, null)));
            }
        }

        public const uint SDL_INIT_EVERYTHING = (SDL_INIT_TIMER | SDL_INIT_AUDIO | SDL_INIT_VIDEO | SDL_INIT_EVENTS | SDL_INIT_JOYSTICK | SDL_INIT_HAPTIC | SDL_INIT_GAMECONTROLLER | SDL_INIT_SENSOR);

        public static Exception? GetErrorAsException()
        {
            byte* ex = GetError();

            if (ex == null || ex[0] == '\0')
            {
                return null;
            }

            return new Exception(Utils.DecodeStringUTF8(ex));
        }

        public static string GetLibraryName()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return "SDL2";
            }

            return "libSDL2";
        }
    }
}