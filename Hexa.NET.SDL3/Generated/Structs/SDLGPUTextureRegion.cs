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
	/// A structure specifying a region of a texture.<br/>
	/// Used when transferring data to or from a texture.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLGPUTextureRegion
	{
		/// <summary>
		/// The texture used in the copy operation. <br/>
		/// </summary>
		public unsafe SDLGPUTexture* Texture;

		/// <summary>
		/// The mip level index to transfer. <br/>
		/// </summary>
		public uint MipLevel;

		/// <summary>
		/// The layer index to transfer. <br/>
		/// </summary>
		public uint Layer;

		/// <summary>
		/// The left offset of the region. <br/>
		/// </summary>
		public uint X;

		/// <summary>
		/// The top offset of the region. <br/>
		/// </summary>
		public uint Y;

		/// <summary>
		/// The front offset of the region. <br/>
		/// </summary>
		public uint Z;

		/// <summary>
		/// The width of the region. <br/>
		/// </summary>
		public uint W;

		/// <summary>
		/// The height of the region. <br/>
		/// </summary>
		public uint H;

		/// <summary>
		/// The depth of the region. <br/>
		/// </summary>
		public uint D;


		public unsafe SDLGPUTextureRegion(SDLGPUTexture* texture = default, uint mipLevel = default, uint layer = default, uint x = default, uint y = default, uint z = default, uint w = default, uint h = default, uint d = default)
		{
			Texture = texture;
			MipLevel = mipLevel;
			Layer = layer;
			X = x;
			Y = y;
			Z = z;
			W = w;
			H = h;
			D = d;
		}


	}

}
