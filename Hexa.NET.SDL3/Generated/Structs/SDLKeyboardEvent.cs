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
	/// Keyboard button event structure (event.key.*)<br/>
	/// The `key` is the base SDL_Keycode generated by pressing the `scancode`<br/>
	/// using the current keyboard layout, applying any options specified in<br/>
	/// SDL_HINT_KEYCODE_OPTIONS. You can get the SDL_Keycode corresponding to the<br/>
	/// event scancode and modifiers directly from the keyboard layout, bypassing<br/>
	/// SDL_HINT_KEYCODE_OPTIONS, by calling SDL_GetKeyFromScancode().<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLKeyboardEvent
	{
		/// <summary>
		/// SDL_EVENT_KEY_DOWN or SDL_EVENT_KEY_UP <br/>
		/// </summary>
		public SDLEventType Type;

		public uint Reserved;
		/// <summary>
		/// In nanoseconds, populated using SDL_GetTicksNS() <br/>
		/// </summary>
		public ulong Timestamp;

		/// <summary>
		/// The window with keyboard focus, if any <br/>
		/// </summary>
		public uint WindowID;

		/// <summary>
		/// The keyboard instance id, or 0 if unknown or virtual <br/>
		/// </summary>
		public uint Which;

		/// <summary>
		/// SDL physical key code <br/>
		/// </summary>
		public SDLScancode Scancode;

		/// <summary>
		/// SDL virtual key code <br/>
		/// </summary>
		public int Key;

		/// <summary>
		/// current key modifiers <br/>
		/// </summary>
		public SDLKeymod Mod;

		/// <summary>
		/// The platform dependent scancode for this event <br/>
		/// </summary>
		public ushort Raw;

		/// <summary>
		/// true if the key is pressed <br/>
		/// </summary>
		public byte Down;

		/// <summary>
		/// true if this is a key repeat <br/>
		/// </summary>
		public byte Repeat;


		public unsafe SDLKeyboardEvent(SDLEventType type = default, uint reserved = default, ulong timestamp = default, uint windowID = default, uint which = default, SDLScancode scancode = default, int key = default, SDLKeymod mod = default, ushort raw = default, bool down = default, bool repeat = default)
		{
			Type = type;
			Reserved = reserved;
			Timestamp = timestamp;
			WindowID = windowID;
			Which = which;
			Scancode = scancode;
			Key = key;
			Mod = mod;
			Raw = raw;
			Down = down ? (byte)1 : (byte)0;
			Repeat = repeat ? (byte)1 : (byte)0;
		}


	}

}
