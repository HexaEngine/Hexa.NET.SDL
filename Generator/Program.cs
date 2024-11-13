// See https://aka.ms/new-console-template for more information
using HexaGen;
using HexaGen.Patching;

List<string> files = [.. Directory.GetFiles("include")];

BatchGenerator batch = new();
batch.Start()
    .Setup<CsCodeGenerator>("generator.json")
    .AddPrePatch(new NamingPatch(["SDL"], NamingPatchOptions.None))
    .AddPrePatch(new EnumNamePatch())
    .Generate(["include/main.h"], "../../../../Hexa.NET.SDL2/Generated", [.. Directory.GetFiles("include")])
    .Finish();