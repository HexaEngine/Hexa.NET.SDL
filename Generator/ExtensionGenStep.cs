// See https://aka.ms/new-console-template for more information
using HexaGen;
using HexaGen.Core.CSharp;
using HexaGen.GenerationSteps;

namespace Generator
{
    public class ExtensionGenStep : ExtensionGenerationStep
    {
        public ExtensionGenStep(CsCodeGenerator generator, CsCodeGeneratorConfig config) : base(generator, config)
        {
        }

        protected override bool FilterExtension(GenContext context, HashSet<CsFunctionVariation> definedExtensions, CsFunctionVariation variation)
        {
            if (variation.Parameters[0].Type.IsVoid) // bug workaround for this void* extension functions.
            {
                return true;
            }
            return base.FilterExtension(context, definedExtensions, variation);
        }
    }
}