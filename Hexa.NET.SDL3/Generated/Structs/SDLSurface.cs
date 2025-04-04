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
	/// A collection of pixels used in software blitting.<br/>
	/// Pixels are arranged in memory in rows, with the top row first. Each row<br/>
	/// occupies an amount of memory given by the pitch (sometimes known as the row<br/>
	/// stride in non-SDL APIs).<br/>
	/// Within each row, pixels are arranged from left to right until the width is<br/>
	/// reached. Each pixel occupies a number of bits appropriate for its format,<br/>
	/// with most formats representing each pixel as one or more whole bytes (in<br/>
	/// some indexed formats, instead multiple pixels are packed into each byte),<br/>
	/// and a byte order given by the format. After encoding all pixels, any<br/>
	/// remaining bytes to reach the pitch are used as padding to reach a desired<br/>
	/// alignment, and have undefined contents.<br/>
	/// When a surface holds YUV format data, the planes are assumed to be<br/>
	/// contiguous without padding between them, e.g. a 32x32 surface in NV12<br/>
	/// format with a pitch of 32 would consist of 32x32 bytes of Y plane followed<br/>
	/// by 32x16 bytes of UV plane.<br/>
	/// When a surface holds MJPG format data, pixels points at the compressed JPEG<br/>
	/// image and pitch is the length of that data.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLSurface
	{
		/// <summary>
		/// The flags of the surface, read-only <br/>
		/// </summary>
		public SDLSurfaceFlags Flags;

		/// <summary>
		/// The format of the surface, read-only <br/>
		/// </summary>
		public SDLPixelFormat Format;

		/// <summary>
		/// The width of the surface, read-only. <br/>
		/// </summary>
		public int W;

		/// <summary>
		/// The height of the surface, read-only. <br/>
		/// </summary>
		public int H;

		/// <summary>
		/// The distance in bytes between rows of pixels, read-only <br/>
		/// </summary>
		public int Pitch;

		/// <summary>
		/// A pointer to the pixels of the surface, the pixels are writeable if non-NULL <br/>
		/// </summary>
		public unsafe void* Pixels;

		/// <summary>
		/// Application reference count, used when freeing surface <br/>
		/// </summary>
		public int Refcount;

		/// <summary>
		/// Reserved for internal use <br/>
		/// </summary>
		public unsafe void* Reserved;


		public unsafe SDLSurface(SDLSurfaceFlags flags = default, SDLPixelFormat format = default, int w = default, int h = default, int pitch = default, void* pixels = default, int refcount = default, void* reserved = default)
		{
			Flags = flags;
			Format = format;
			W = w;
			H = h;
			Pitch = pitch;
			Pixels = pixels;
			Refcount = refcount;
			Reserved = reserved;
		}


	}

}
