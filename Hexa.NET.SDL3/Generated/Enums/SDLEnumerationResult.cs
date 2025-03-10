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
	/// Possible results from an enumeration callback.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_EnumerationResult")]
	[Flags]
	public enum SDLEnumerationResult : int
	{
		/// <summary>
		/// Value that requests that enumeration continue. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_ENUM_CONTINUE")]
		[NativeName(NativeNameType.Value, "0")]
		EnumContinue = unchecked(0),

		/// <summary>
		/// Value that requests that enumeration stop, successfully. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_ENUM_SUCCESS")]
		[NativeName(NativeNameType.Value, "1")]
		EnumSuccess = unchecked(1),

		/// <summary>
		/// Value that requests that enumeration stop, as a failure. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_ENUM_FAILURE")]
		[NativeName(NativeNameType.Value, "2")]
		EnumFailure = unchecked(2),
	}
}
