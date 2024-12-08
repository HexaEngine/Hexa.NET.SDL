namespace Hexa.NET.SDL3
{
    public static partial class SDL
    {
        static SDL()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            return "sdl3";
        }
    }
}