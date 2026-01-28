// See https://aka.ms/new-console-template for more information
using HexaGen;
using HexaGen.FunctionGeneration;
using HexaGen.GenerationSteps;

namespace Generator
{
    public class CodeGenerator : CsCodeGenerator
    {
        public CodeGenerator(CsCodeGeneratorConfig config) : base(config)
        {
        }

        protected override void ConfigureGeneratorCore(List<PreProcessStep> preProcessSteps, List<GenerationStep> generationSteps, out FunctionGenerator funcGen)
        {
            base.ConfigureGeneratorCore(preProcessSteps, generationSteps, out funcGen);
            generationSteps.RemoveAll(step => step is ExtensionGenerationStep);
            generationSteps.Add(new ExtensionGenStep(this, config));
        }
    }
}