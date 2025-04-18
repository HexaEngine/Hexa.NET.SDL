// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;

namespace Hexa.NET.SDL3
{
	/// <summary>
	/// Pixel type.<br/>
	/// <br/>
	/// </summary>
	[Flags]
	public enum SDLPixelType : int
	{
		Unknown = unchecked(0),
		Index1 = unchecked(1),
		Index4 = unchecked(2),
		Index8 = unchecked(3),
		Packed8 = unchecked(4),
		Packed16 = unchecked(5),
		Packed32 = unchecked(6),
		Arrayu8 = unchecked(7),
		Arrayu16 = unchecked(8),
		Arrayu32 = unchecked(9),
		Arrayf16 = unchecked(10),
		Arrayf32 = unchecked(11),
		/// <summary>
		/// appended at the end for compatibility with sdl2-compat:  <br/>
		/// </summary>
		Index2 = unchecked(12),
	}
}
