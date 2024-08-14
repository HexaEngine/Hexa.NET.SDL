// See https://aka.ms/new-console-template for more information
using HexaGen;

CsCodeGeneratorSettings settings = CsCodeGeneratorSettings.Load("generator.json");
CsCodeGenerator generator = new(settings);
generator.Generate(["include/main.h"], "../../../../Hexa.NET.SDL2/Generated");