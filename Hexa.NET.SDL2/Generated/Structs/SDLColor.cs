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

namespace Hexa.NET.SDL2
{
	/// <summary>
	/// The bits of this structure can be directly reinterpreted as an<br/>
	/// integer-packed color which uses the SDL_PIXELFORMAT_RGBA32 format<br/>
	/// (SDL_PIXELFORMAT_ABGR8888 on little-endian systems and<br/>
	/// SDL_PIXELFORMAT_RGBA8888 on big-endian systems).<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLColor
	{
		public byte R;
		public byte G;
		public byte B;
		public byte A;

		public unsafe SDLColor(byte r = default, byte g = default, byte b = default, byte a = default)
		{
			R = r;
			G = g;
			B = b;
			A = a;
		}


	}

}
