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
    [Flags]
    public enum SDLKeymod : ushort
	{
		None = unchecked((ushort)0x0000u),
		Lshift = unchecked((ushort)0x0001u),
		Rshift = unchecked((ushort)0x0002u),
		Lctrl = unchecked((ushort)0x0040u),
		Rctrl = unchecked((ushort)0x0080u),
		Lalt = unchecked((ushort)0x0100u),
		Ralt = unchecked((ushort)0x0200u),
		Lgui = unchecked((ushort)0x0400u),
		Rgui = unchecked((ushort)0x0800u),
		Num = unchecked((ushort)0x1000u),
		Caps = unchecked((ushort)0x2000u),
		Mode = unchecked((ushort)0x4000u),
		Scroll = unchecked((ushort)0x8000u),
		Ctrl = (Lctrl|Rctrl),
		Shift = (Lshift|Rshift),
		Alt = (Lalt|Ralt),
		Gui = (Lgui|Rgui),
	}
}
