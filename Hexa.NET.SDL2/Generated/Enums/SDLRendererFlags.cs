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

namespace Hexa.NET.SDL2
{
	/// <summary>
	/// Flags used when creating a rendering context<br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_RendererFlags")]
	public enum SDLRendererFlags : int
	{
		/// <summary>
		/// The renderer is a software fallback <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_RENDERER_SOFTWARE")]
		[NativeName(NativeNameType.Value, "1")]
		Software = unchecked(1),

		/// <summary>
		/// The renderer uses hardware<br/>
		/// acceleration <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_RENDERER_ACCELERATED")]
		[NativeName(NativeNameType.Value, "2")]
		Accelerated = unchecked(2),

		/// <summary>
		/// Present is synchronized<br/>
		/// with the refresh rate <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_RENDERER_PRESENTVSYNC")]
		[NativeName(NativeNameType.Value, "4")]
		Presentvsync = unchecked(4),

		/// <summary>
		/// The renderer supports<br/>
		/// rendering to texture <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_RENDERER_TARGETTEXTURE")]
		[NativeName(NativeNameType.Value, "8")]
		Targettexture = unchecked(8),
	}
}
