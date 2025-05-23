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
	/// A structure specifying the blend state of a color target.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLGPUColorTargetBlendState
	{
		/// <summary>
		/// The value to be multiplied by the source RGB value. <br/>
		/// </summary>
		public SDLGPUBlendFactor SrcColorBlendfactor;

		/// <summary>
		/// The value to be multiplied by the destination RGB value. <br/>
		/// </summary>
		public SDLGPUBlendFactor DstColorBlendfactor;

		/// <summary>
		/// The blend operation for the RGB components. <br/>
		/// </summary>
		public SDLGPUBlendOp ColorBlendOp;

		/// <summary>
		/// The value to be multiplied by the source alpha. <br/>
		/// </summary>
		public SDLGPUBlendFactor SrcAlphaBlendfactor;

		/// <summary>
		/// The value to be multiplied by the destination alpha. <br/>
		/// </summary>
		public SDLGPUBlendFactor DstAlphaBlendfactor;

		/// <summary>
		/// The blend operation for the alpha component. <br/>
		/// </summary>
		public SDLGPUBlendOp AlphaBlendOp;

		/// <summary>
		/// A bitmask specifying which of the RGBA components are enabled for writing. Writes to all channels if enable_color_write_mask is false. <br/>
		/// </summary>
		public SDLGPUColorComponentFlags ColorWriteMask;

		/// <summary>
		/// Whether blending is enabled for the color target. <br/>
		/// </summary>
		public byte EnableBlend;

		/// <summary>
		/// Whether the color write mask is enabled. <br/>
		/// </summary>
		public byte EnableColorWriteMask;

		public byte Padding1;
		public byte Padding2;

		public unsafe SDLGPUColorTargetBlendState(SDLGPUBlendFactor srcColorBlendfactor = default, SDLGPUBlendFactor dstColorBlendfactor = default, SDLGPUBlendOp colorBlendOp = default, SDLGPUBlendFactor srcAlphaBlendfactor = default, SDLGPUBlendFactor dstAlphaBlendfactor = default, SDLGPUBlendOp alphaBlendOp = default, SDLGPUColorComponentFlags colorWriteMask = default, bool enableBlend = default, bool enableColorWriteMask = default, byte padding1 = default, byte padding2 = default)
		{
			SrcColorBlendfactor = srcColorBlendfactor;
			DstColorBlendfactor = dstColorBlendfactor;
			ColorBlendOp = colorBlendOp;
			SrcAlphaBlendfactor = srcAlphaBlendfactor;
			DstAlphaBlendfactor = dstAlphaBlendfactor;
			AlphaBlendOp = alphaBlendOp;
			ColorWriteMask = colorWriteMask;
			EnableBlend = enableBlend ? (byte)1 : (byte)0;
			EnableColorWriteMask = enableColorWriteMask ? (byte)1 : (byte)0;
			Padding1 = padding1;
			Padding2 = padding2;
		}


	}

}
