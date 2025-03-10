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
	[Flags]
	public enum SDLRendererFlags : int
	{
		/// <summary>
		/// The renderer is a software fallback <br/>
		/// </summary>
		Software = unchecked(1),

		/// <summary>
		/// The renderer uses hardware<br/>
		/// acceleration <br/>
		/// </summary>
		Accelerated = unchecked(2),

		/// <summary>
		/// Present is synchronized<br/>
		/// with the refresh rate <br/>
		/// </summary>
		Presentvsync = unchecked(4),

		/// <summary>
		/// The renderer supports<br/>
		/// rendering to texture <br/>
		/// </summary>
		Targettexture = unchecked(8),
	}
}
