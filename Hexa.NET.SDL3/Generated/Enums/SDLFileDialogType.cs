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
	/// Various types of file dialogs.<br/>
	/// This is used by SDL_ShowFileDialogWithProperties() to decide what kind of<br/>
	/// dialog to present to the user.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_FileDialogType")]
	[Flags]
	public enum SDLFileDialogType : int
	{
		[NativeName(NativeNameType.EnumItem, "SDL_FILEDIALOG_OPENFILE")]
		[NativeName(NativeNameType.Value, "0")]
		Openfile = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "SDL_FILEDIALOG_SAVEFILE")]
		[NativeName(NativeNameType.Value, "1")]
		Savefile = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "SDL_FILEDIALOG_OPENFOLDER")]
		[NativeName(NativeNameType.Value, "2")]
		Openfolder = unchecked(2),
	}
}
