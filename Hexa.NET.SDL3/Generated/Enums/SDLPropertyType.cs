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
	/// SDL property type<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_PropertyType")]
	[Flags]
	public enum SDLPropertyType : int
	{
		[NativeName(NativeNameType.EnumItem, "SDL_PROPERTY_TYPE_INVALID")]
		[NativeName(NativeNameType.Value, "0")]
		Invalid = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "SDL_PROPERTY_TYPE_POINTER")]
		[NativeName(NativeNameType.Value, "1")]
		Pointer = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "SDL_PROPERTY_TYPE_STRING")]
		[NativeName(NativeNameType.Value, "2")]
		String = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "SDL_PROPERTY_TYPE_NUMBER")]
		[NativeName(NativeNameType.Value, "3")]
		Number = unchecked(3),
		[NativeName(NativeNameType.EnumItem, "SDL_PROPERTY_TYPE_FLOAT")]
		[NativeName(NativeNameType.Value, "4")]
		Float = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "SDL_PROPERTY_TYPE_BOOLEAN")]
		[NativeName(NativeNameType.Value, "5")]
		Boolean = unchecked(5),
	}
}
