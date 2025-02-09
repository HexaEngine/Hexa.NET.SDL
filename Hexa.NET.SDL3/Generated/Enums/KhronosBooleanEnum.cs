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
	/// Enumerated boolean type<br/>
	/// Values other than zero should be considered to be true.  Therefore<br/>
	/// comparisons should not be made against KHRONOS_TRUE.<br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "khronos_boolean_enum_t")]
	[Flags]
	public enum KhronosBooleanEnum : int
	{
		[NativeName(NativeNameType.EnumItem, "KHRONOS_FALSE")]
		[NativeName(NativeNameType.Value, "0")]
		False = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "KHRONOS_TRUE")]
		[NativeName(NativeNameType.Value, "1")]
		True = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "KHRONOS_BOOLEAN_ENUM_FORCE_SIZE")]
		[NativeName(NativeNameType.Value, "2147483647")]
		ForceSize = unchecked(2147483647),
	}
}
