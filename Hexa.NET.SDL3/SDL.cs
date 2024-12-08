namespace Hexa.NET.SDL3
{
    using HexaGen.Runtime;
    using System.Runtime.InteropServices;

    public static unsafe partial class SDL
    {
        static SDL()
        {
            InitApi();
        }

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
                return "SDL3";
            }

            return "libSDL3";
        }
    }
}