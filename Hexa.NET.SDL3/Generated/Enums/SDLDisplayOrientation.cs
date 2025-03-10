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
	/// Display orientation values; the way a display is rotated.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_DisplayOrientation")]
	[Flags]
	public enum SDLDisplayOrientation : int
	{
		/// <summary>
		/// The display orientation can't be determined <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_ORIENTATION_UNKNOWN")]
		[NativeName(NativeNameType.Value, "0")]
		Unknown = unchecked(0),

		/// <summary>
		/// The display is in landscape mode, with the right side up, relative to portrait mode <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_ORIENTATION_LANDSCAPE")]
		[NativeName(NativeNameType.Value, "1")]
		Landscape = unchecked(1),

		/// <summary>
		/// The display is in landscape mode, with the left side up, relative to portrait mode <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_ORIENTATION_LANDSCAPE_FLIPPED")]
		[NativeName(NativeNameType.Value, "2")]
		LandscapeFlipped = unchecked(2),

		/// <summary>
		/// The display is in portrait mode <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_ORIENTATION_PORTRAIT")]
		[NativeName(NativeNameType.Value, "3")]
		Portrait = unchecked(3),

		/// <summary>
		/// The display is in portrait mode, upside down <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_ORIENTATION_PORTRAIT_FLIPPED")]
		[NativeName(NativeNameType.Value, "4")]
		PortraitFlipped = unchecked(4),
	}
}
