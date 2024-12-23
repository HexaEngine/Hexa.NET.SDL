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
	/// Colorspace color range, as described by<br/>
	/// https://www.itu.int/rec/R-REC-BT.2100-2-201807-I/en<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_ColorRange")]
	[Flags]
	public enum SDLColorRange : int
	{
		[NativeName(NativeNameType.EnumItem, "SDL_COLOR_RANGE_UNKNOWN")]
		[NativeName(NativeNameType.Value, "0")]
		Unknown = unchecked(0),
		/// <summary>
		/// Narrow range, e.g. 16-235 for 8-bit RGB and luma, and 16-240 for 8-bit chroma <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_COLOR_RANGE_LIMITED")]
		[NativeName(NativeNameType.Value, "1")]
		Limited = unchecked(1),

		/// <summary>
		/// Full range, e.g. 0-255 for 8-bit RGB and luma, and 1-255 for 8-bit chroma <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_COLOR_RANGE_FULL")]
		[NativeName(NativeNameType.Value, "2")]
		Full = unchecked(2),
	}
}
