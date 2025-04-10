// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;

namespace Hexa.NET.SDL3
{
	/// <summary>
	/// A structure specifying the parameters of a compute pipeline state.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLGPUComputePipelineCreateInfo
	{
		/// <summary>
		/// The size in bytes of the compute shader code pointed to. <br/>
		/// </summary>
		public nuint CodeSize;

		/// <summary>
		/// A pointer to compute shader code. <br/>
		/// </summary>
		public unsafe byte* Code;

		/// <summary>
		/// A pointer to a null-terminated UTF-8 string specifying the entry point function name for the shader. <br/>
		/// </summary>
		public unsafe byte* Entrypoint;

		/// <summary>
		/// The format of the compute shader code. <br/>
		/// </summary>
		public SDLGPUShaderFormat Format;

		/// <summary>
		/// The number of samplers defined in the shader. <br/>
		/// </summary>
		public uint NumSamplers;

		/// <summary>
		/// The number of readonly storage textures defined in the shader. <br/>
		/// </summary>
		public uint NumReadonlyStorageTextures;

		/// <summary>
		/// The number of readonly storage buffers defined in the shader. <br/>
		/// </summary>
		public uint NumReadonlyStorageBuffers;

		/// <summary>
		/// The number of read-write storage textures defined in the shader. <br/>
		/// </summary>
		public uint NumReadwriteStorageTextures;

		/// <summary>
		/// The number of read-write storage buffers defined in the shader. <br/>
		/// </summary>
		public uint NumReadwriteStorageBuffers;

		/// <summary>
		/// The number of uniform buffers defined in the shader. <br/>
		/// </summary>
		public uint NumUniformBuffers;

		/// <summary>
		/// The number of threads in the X dimension. This should match the value in the shader. <br/>
		/// </summary>
		public uint ThreadcountX;

		/// <summary>
		/// The number of threads in the Y dimension. This should match the value in the shader. <br/>
		/// </summary>
		public uint ThreadcountY;

		/// <summary>
		/// The number of threads in the Z dimension. This should match the value in the shader. <br/>
		/// </summary>
		public uint ThreadcountZ;

		/// <summary>
		/// A properties ID for extensions. Should be 0 if no extensions are needed. <br/>
		/// </summary>
		public uint Props;


		public unsafe SDLGPUComputePipelineCreateInfo(nuint codeSize = default, byte* code = default, byte* entrypoint = default, SDLGPUShaderFormat format = default, uint numSamplers = default, uint numReadonlyStorageTextures = default, uint numReadonlyStorageBuffers = default, uint numReadwriteStorageTextures = default, uint numReadwriteStorageBuffers = default, uint numUniformBuffers = default, uint threadcountX = default, uint threadcountY = default, uint threadcountZ = default, uint props = default)
		{
			CodeSize = codeSize;
			Code = code;
			Entrypoint = entrypoint;
			Format = format;
			NumSamplers = numSamplers;
			NumReadonlyStorageTextures = numReadonlyStorageTextures;
			NumReadonlyStorageBuffers = numReadonlyStorageBuffers;
			NumReadwriteStorageTextures = numReadwriteStorageTextures;
			NumReadwriteStorageBuffers = numReadwriteStorageBuffers;
			NumUniformBuffers = numUniformBuffers;
			ThreadcountX = threadcountX;
			ThreadcountY = threadcountY;
			ThreadcountZ = threadcountZ;
			Props = props;
		}


	}

}
