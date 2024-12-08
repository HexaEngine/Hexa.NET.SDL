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
	/// A structure specifying the stencil operation state of a graphics pipeline.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_GPUStencilOpState")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLGPUStencilOpState
	{
		/// <summary>
		/// The action performed on samples that fail the stencil test. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "fail_op")]
		[NativeName(NativeNameType.Type, "SDL_GPUStencilOp")]
		public SDLGPUStencilOp FailOp;

		/// <summary>
		/// The action performed on samples that pass the depth and stencil tests. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "pass_op")]
		[NativeName(NativeNameType.Type, "SDL_GPUStencilOp")]
		public SDLGPUStencilOp PassOp;

		/// <summary>
		/// The action performed on samples that pass the stencil test and fail the depth test. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "depth_fail_op")]
		[NativeName(NativeNameType.Type, "SDL_GPUStencilOp")]
		public SDLGPUStencilOp DepthFailOp;

		/// <summary>
		/// The comparison operator used in the stencil test. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "compare_op")]
		[NativeName(NativeNameType.Type, "SDL_GPUCompareOp")]
		public SDLGPUCompareOp CompareOp;


		public unsafe SDLGPUStencilOpState(SDLGPUStencilOp failOp = default, SDLGPUStencilOp passOp = default, SDLGPUStencilOp depthFailOp = default, SDLGPUCompareOp compareOp = default)
		{
			FailOp = failOp;
			PassOp = passOp;
			DepthFailOp = depthFailOp;
			CompareOp = compareOp;
		}


	}

}