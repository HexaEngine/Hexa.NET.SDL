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
	/// <br/>
	/// Get the current audio state.<br/>
	/// <br/>
	/// @<br/>
	/// { <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_AudioStatus")]
	[Flags]
	public enum SDLAudioStatus : int
	{
		[NativeName(NativeNameType.EnumItem, "SDL_AUDIO_STOPPED")]
		[NativeName(NativeNameType.Value, "0")]
		Stopped = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "SDL_AUDIO_PLAYING")]
		[NativeName(NativeNameType.Value, "1")]
		Playing = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "SDL_AUDIO_PAUSED")]
		[NativeName(NativeNameType.Value, "2")]
		Paused = unchecked(2),
	}
}