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
	/// The type of action to request from SDL_PeepEvents().<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_EventAction")]
	[Flags]
	public enum SDLEventAction : int
	{
		/// <summary>
		/// Add events to the back of the queue. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_ADDEVENT")]
		[NativeName(NativeNameType.Value, "0")]
		Addevent = unchecked(0),

		/// <summary>
		/// Check but don't remove events from the queue front. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_PEEKEVENT")]
		[NativeName(NativeNameType.Value, "1")]
		Peekevent = unchecked(1),

		/// <summary>
		/// Retrieve/remove events from the front of the queue. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_GETEVENT")]
		[NativeName(NativeNameType.Value, "2")]
		Getevent = unchecked(2),
	}
}
