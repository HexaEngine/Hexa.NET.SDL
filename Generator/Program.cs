// See https://aka.ms/new-console-template for more information
using CppAst;
using HexaGen;
using HexaGen.Core.Mapping;
using HexaGen.Patching;
using System.Diagnostics.CodeAnalysis;

CsCodeGeneratorConfig config = CsCodeGeneratorConfig.Load("generator.json");
CsCodeGenerator generator = new(config);
generator.PatchEngine.RegisterPrePatch(new NamingPatch(["SDL"], NamingPatchOptions.None));
generator.PatchEngine.RegisterPrePatch(new EnumNamePatch());
generator.LogEvent += (s, m) => Console.WriteLine($"{s}: {m}");
generator.Generate(["include/main.h"], "../../../../Hexa.NET.SDL2/Generated");

public class EnumNamePatch : PrePatch
{
    protected override void PatchEnum(CsCodeGeneratorConfig settings, CppEnum cppEnum)
    {
        if (cppEnum.Name == "SDL_KeyCode")
        {
            EnumMapping mapping = new(cppEnum.Name, null, null); // let the generator figure out the name on it's own, no need to interfere.
            EnumPrefix prefix = settings.GetEnumNamePrefixEx(cppEnum.Name);
            foreach (var item in cppEnum.Items)
            {
                var name = item.Name;
                string newName = settings.GetEnumNameEx(name, prefix);

                if (newName.StartsWith("Sdlk"))
                {
                    newName = $"K{newName["Sdlk".Length..]}";
                }

                EnumItemMapping itemMapping = new(item.Name, newName, null, null);
                mapping.ItemMappings.Add(itemMapping);
            }

            settings.EnumMappings.Add(mapping);
        }
    }

    protected override void PatchTypedef(CsCodeGeneratorConfig settings, CppTypedef cppTypedef)
    {
        if (IsEnum(cppTypedef, out var cppEnum))
        {
            PatchEnum(settings, cppEnum);
        }
    }

    public static bool IsEnum(CppType cppType, [NotNullWhen(true)] out CppEnum? cppEnum)
    {
        if (cppType is CppTypedef cppTypedef)
        {
            return IsEnum(cppTypedef.ElementType, out cppEnum);
        }

        if (cppType is CppPointerType cppPointerType)
        {
            return IsEnum(cppPointerType.ElementType, out cppEnum);
        }

        if (cppType is CppEnum cppEnum2)
        {
            cppEnum = cppEnum2;
            return true;
        }

        cppEnum = null;
        return false;
    }
}