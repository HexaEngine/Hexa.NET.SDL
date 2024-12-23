// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;

namespace Hexa.NET.SDL3
{
	/// <summary>
	/// An event triggered when the clipboard contents have changed<br/>
	/// (event.clipboard.*)<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_ClipboardEvent")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLClipboardEvent
	{
		/// <summary>
		/// SDL_EVENT_CLIPBOARD_UPDATE <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "type")]
		[NativeName(NativeNameType.Type, "SDL_EventType")]
		public SDLEventType Type;

		[NativeName(NativeNameType.Field, "reserved")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Reserved;
		/// <summary>
		/// In nanoseconds, populated using SDL_GetTicksNS() <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "timestamp")]
		[NativeName(NativeNameType.Type, "Uint64")]
		public ulong Timestamp;


		public unsafe SDLClipboardEvent(SDLEventType type = default, uint reserved = default, ulong timestamp = default)
		{
			Type = type;
			Reserved = reserved;
			Timestamp = timestamp;
		}


	}

}
