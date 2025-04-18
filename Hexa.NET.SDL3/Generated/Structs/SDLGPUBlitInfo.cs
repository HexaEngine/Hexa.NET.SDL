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
	/// A structure containing parameters for a blit command.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLGPUBlitInfo
	{
		/// <summary>
		/// The source region for the blit. <br/>
		/// </summary>
		public SDLGPUBlitRegion Source;

		/// <summary>
		/// The destination region for the blit. <br/>
		/// </summary>
		public SDLGPUBlitRegion Destination;

		/// <summary>
		/// What is done with the contents of the destination before the blit. <br/>
		/// </summary>
		public SDLGPULoadOp LoadOp;

		/// <summary>
		/// The color to clear the destination region to before the blit. Ignored if load_op is not SDL_GPU_LOADOP_CLEAR. <br/>
		/// </summary>
		public SDLFColor ClearColor;

		/// <summary>
		/// The flip mode for the source region. <br/>
		/// </summary>
		public SDLFlipMode FlipMode;

		/// <summary>
		/// The filter mode used when blitting. <br/>
		/// </summary>
		public SDLGPUFilter Filter;

		/// <summary>
		/// true cycles the destination texture if it is already bound. <br/>
		/// </summary>
		public byte Cycle;

		public byte Padding1;
		public byte Padding2;
		public byte Padding3;

		public unsafe SDLGPUBlitInfo(SDLGPUBlitRegion source = default, SDLGPUBlitRegion destination = default, SDLGPULoadOp loadOp = default, SDLFColor clearColor = default, SDLFlipMode flipMode = default, SDLGPUFilter filter = default, bool cycle = default, byte padding1 = default, byte padding2 = default, byte padding3 = default)
		{
			Source = source;
			Destination = destination;
			LoadOp = loadOp;
			ClearColor = clearColor;
			FlipMode = flipMode;
			Filter = filter;
			Cycle = cycle ? (byte)1 : (byte)0;
			Padding1 = padding1;
			Padding2 = padding2;
			Padding3 = padding3;
		}


	}

}
