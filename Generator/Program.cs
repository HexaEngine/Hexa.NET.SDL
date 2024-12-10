// See https://aka.ms/new-console-template for more information
using HexaGen;
using HexaGen.Patching;
using System.Text;
using System.Text.RegularExpressions;

// SDL2
List<string> filesSdl2 = [.. Directory.GetFiles("sdl2/include")];

// SDL3
Regex regex = new("#include <(.*)>", RegexOptions.Multiline | RegexOptions.Compiled);
foreach (var file in Directory.GetFiles("sdl3/include"))
{
    var content = File.ReadAllText(file);
    StringBuilder sb = new(content);
    var matches = regex.Matches(content);
    foreach (Match match in matches)
    {
        var value = match.Groups[1].Value;
        if (!value.StartsWith("SDL3/"))
        {
            continue;
        }
        value = value.Replace("SDL3/", "");
        sb.Replace(match.Value, $"#include \"{value}\"");
    }
    File.WriteAllText(file, sb.ToString());
}

List<string> filesSdl3 = [.. Directory.GetFiles("sdl3/include")];

for (int i = filesSdl3.Count - 1; i >= 0; i--)
{
    var file = filesSdl3[i];
    if (file.Contains("opengl"))
    {
        filesSdl3.RemoveAt(i); // we can't process opengl headers
    }
}

BatchGenerator.Create()
    // SDL 2
    .Setup<CsCodeGenerator>("sdl2/generator.json")
    .AddPrePatch(new NamingPatch(["SDL"], NamingPatchOptions.None))
    .AddPrePatch(new EnumNamePatch())
    .Generate(["sdl2/include/main.h"], "../../../../Hexa.NET.SDL2/Generated", filesSdl2)

    // SDL 3
    .Setup<CsCodeGenerator>("sdl3/generator.json")
    .AddPrePatch(new NamingPatch(["SDL"], NamingPatchOptions.None))
    .AddPrePatch(new ConstantsToEnumPatch("SDL_BLENDMODE_", "SDLBlendMode", "uint"))
    //.AddPrePatch(new ConstantsToEnumPatch("SDL_WINDOW_", "SDLWindowFlags", "uint"))
    //.AddPrePatch(new ConstantsToEnumPatch("SDL_MESSAGEBOX_", "SDLMessageBoxFlags", "uint"))
    //.AddPrePatch(new ConstantsToEnumPatch("SDL_BUTTON_", "SDLMouseButtonFlags", "uint"))
    //.AddPrePatch(new ConstantsToEnumPatch("SDL_INIT_", "SDLInitFlags", "uint"))
    .AddPrePatch(new ConstantsToEnumPatch("SDL_GLOB_", "SDLGlobFlags", "uint"))
    //.AddPrePatch(new ConstantsToEnumPatch("SDL_KMOD_", "SDLKeymod", "ushort"))
    .AddPrePatch(new ConstantsToEnumPatch("SDL_PEN_INPUT_", "SDLPenInputFlags", "uint"))
    .AddPrePatch(new ConstantsToEnumPatch("SDL_SURFACE_", "SDLSurfaceFlags", "uint"))
    .AddPrePatch(new ConstantsToEnumPatch("SDL_MESSAGEBOX_BUTTON_", "SDLMessageBoxButtonFlags", "uint"))
    .AddPrePatch(new ConstantsToEnumPatch("VERBOSE_", "SDLTestVerboseFlags", "uint"))
    .AddPrePatch(new ConstantsToEnumPatch("SDL_GPU_BUFFERUSAGE_", "SDLGPUBufferUsageFlags", "uint"))
    //.AddPrePatch(new ConstantsToEnumPatch("SDL_GPU_COLORCOMPONENT_", "SDLGPUColorComponentFlags", "byte"))
    .AddPrePatch(new ConstantsToEnumPatch("SDL_GPU_SHADERFORMAT_", "SDLGPUShaderFormat", "uint"))
    .AddPrePatch(new ConstantsToEnumPatch("SDL_GPU_TEXTUREUSAGE_", "SDLGPUTextureUsageFlags", "uint"))
    .Generate(filesSdl3, "../../../../Hexa.NET.SDL3/Generated")

    .Finish();