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
	/// Cursor types for SDL_CreateSystemCursor().<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_SystemCursor")]
	[Flags]
	public enum SDLSystemCursor : int
	{
		/// <summary>
		/// Default cursor. Usually an arrow. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_DEFAULT")]
		[NativeName(NativeNameType.Value, "0")]
		Default = unchecked(0),

		/// <summary>
		/// Text selection. Usually an I-beam. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_TEXT")]
		[NativeName(NativeNameType.Value, "1")]
		Text = unchecked(1),

		/// <summary>
		/// Wait. Usually an hourglass or watch or spinning ball. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_WAIT")]
		[NativeName(NativeNameType.Value, "2")]
		Wait = unchecked(2),

		/// <summary>
		/// Crosshair. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_CROSSHAIR")]
		[NativeName(NativeNameType.Value, "3")]
		Crosshair = unchecked(3),

		/// <summary>
		/// Program is busy but still interactive. Usually it's WAIT with an arrow. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_PROGRESS")]
		[NativeName(NativeNameType.Value, "4")]
		Progress = unchecked(4),

		/// <summary>
		/// Double arrow pointing northwest and southeast. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_NWSE_RESIZE")]
		[NativeName(NativeNameType.Value, "5")]
		NwseResize = unchecked(5),

		/// <summary>
		/// Double arrow pointing northeast and southwest. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_NESW_RESIZE")]
		[NativeName(NativeNameType.Value, "6")]
		NeswResize = unchecked(6),

		/// <summary>
		/// Double arrow pointing west and east. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_EW_RESIZE")]
		[NativeName(NativeNameType.Value, "7")]
		EwResize = unchecked(7),

		/// <summary>
		/// Double arrow pointing north and south. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_NS_RESIZE")]
		[NativeName(NativeNameType.Value, "8")]
		NsResize = unchecked(8),

		/// <summary>
		/// Four pointed arrow pointing north, south, east, and west. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_MOVE")]
		[NativeName(NativeNameType.Value, "9")]
		Move = unchecked(9),

		/// <summary>
		/// Not permitted. Usually a slashed circle or crossbones. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_NOT_ALLOWED")]
		[NativeName(NativeNameType.Value, "10")]
		NotAllowed = unchecked(10),

		/// <summary>
		/// Pointer that indicates a link. Usually a pointing hand. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_POINTER")]
		[NativeName(NativeNameType.Value, "11")]
		Pointer = unchecked(11),

		/// <summary>
		/// Window resize top-left. This may be a single arrow or a double arrow like NWSE_RESIZE. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_NW_RESIZE")]
		[NativeName(NativeNameType.Value, "12")]
		NwResize = unchecked(12),

		/// <summary>
		/// Window resize top. May be NS_RESIZE. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_N_RESIZE")]
		[NativeName(NativeNameType.Value, "13")]
		NResize = unchecked(13),

		/// <summary>
		/// Window resize top-right. May be NESW_RESIZE. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_NE_RESIZE")]
		[NativeName(NativeNameType.Value, "14")]
		NeResize = unchecked(14),

		/// <summary>
		/// Window resize right. May be EW_RESIZE. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_E_RESIZE")]
		[NativeName(NativeNameType.Value, "15")]
		EResize = unchecked(15),

		/// <summary>
		/// Window resize bottom-right. May be NWSE_RESIZE. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_SE_RESIZE")]
		[NativeName(NativeNameType.Value, "16")]
		SeResize = unchecked(16),

		/// <summary>
		/// Window resize bottom. May be NS_RESIZE. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_S_RESIZE")]
		[NativeName(NativeNameType.Value, "17")]
		SResize = unchecked(17),

		/// <summary>
		/// Window resize bottom-left. May be NESW_RESIZE. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_SW_RESIZE")]
		[NativeName(NativeNameType.Value, "18")]
		SwResize = unchecked(18),

		/// <summary>
		/// Window resize left. May be EW_RESIZE. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_W_RESIZE")]
		[NativeName(NativeNameType.Value, "19")]
		WResize = unchecked(19),

		[NativeName(NativeNameType.EnumItem, "SDL_SYSTEM_CURSOR_COUNT")]
		[NativeName(NativeNameType.Value, "20")]
		Count = unchecked(20),
	}
}
