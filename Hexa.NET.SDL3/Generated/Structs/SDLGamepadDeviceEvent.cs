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
	/// Gamepad device event structure (event.gdevice.*)<br/>
	/// Joysticks that are supported gamepads receive both an SDL_JoyDeviceEvent<br/>
	/// and an SDL_GamepadDeviceEvent.<br/>
	/// SDL will send GAMEPAD_ADDED events for joysticks that are already plugged<br/>
	/// in during SDL_Init() and are recognized as gamepads. It will also send<br/>
	/// events for joysticks that get gamepad mappings at runtime.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_GamepadDeviceEvent")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLGamepadDeviceEvent
	{
		/// <summary>
		/// SDL_EVENT_GAMEPAD_ADDED, SDL_EVENT_GAMEPAD_REMOVED, or SDL_EVENT_GAMEPAD_REMAPPED, SDL_EVENT_GAMEPAD_UPDATE_COMPLETE or SDL_EVENT_GAMEPAD_STEAM_HANDLE_UPDATED <br/>
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

		/// <summary>
		/// The joystick instance id <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "which")]
		[NativeName(NativeNameType.Type, "SDL_JoystickID")]
		public int Which;


		public unsafe SDLGamepadDeviceEvent(SDLEventType type = default, uint reserved = default, ulong timestamp = default, int which = default)
		{
			Type = type;
			Reserved = reserved;
			Timestamp = timestamp;
			Which = which;
		}


	}

}
