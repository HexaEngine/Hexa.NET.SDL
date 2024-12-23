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
	/// An enum of some common joystick types.<br/>
	/// In some cases, SDL can identify a low-level joystick as being a certain<br/>
	/// type of device, and will report it through SDL_GetJoystickType (or<br/>
	/// SDL_GetJoystickTypeForID).<br/>
	/// This is by no means a complete list of everything that can be plugged into<br/>
	/// a computer.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_JoystickType")]
	[Flags]
	public enum SDLJoystickType : int
	{
		[NativeName(NativeNameType.EnumItem, "SDL_JOYSTICK_TYPE_UNKNOWN")]
		[NativeName(NativeNameType.Value, "0")]
		Unknown = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "SDL_JOYSTICK_TYPE_GAMEPAD")]
		[NativeName(NativeNameType.Value, "1")]
		Gamepad = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "SDL_JOYSTICK_TYPE_WHEEL")]
		[NativeName(NativeNameType.Value, "2")]
		Wheel = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "SDL_JOYSTICK_TYPE_ARCADE_STICK")]
		[NativeName(NativeNameType.Value, "3")]
		ArcadeStick = unchecked(3),
		[NativeName(NativeNameType.EnumItem, "SDL_JOYSTICK_TYPE_FLIGHT_STICK")]
		[NativeName(NativeNameType.Value, "4")]
		FlightStick = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "SDL_JOYSTICK_TYPE_DANCE_PAD")]
		[NativeName(NativeNameType.Value, "5")]
		DancePad = unchecked(5),
		[NativeName(NativeNameType.EnumItem, "SDL_JOYSTICK_TYPE_GUITAR")]
		[NativeName(NativeNameType.Value, "6")]
		Guitar = unchecked(6),
		[NativeName(NativeNameType.EnumItem, "SDL_JOYSTICK_TYPE_DRUM_KIT")]
		[NativeName(NativeNameType.Value, "7")]
		DrumKit = unchecked(7),
		[NativeName(NativeNameType.EnumItem, "SDL_JOYSTICK_TYPE_ARCADE_PAD")]
		[NativeName(NativeNameType.Value, "8")]
		ArcadePad = unchecked(8),
		[NativeName(NativeNameType.EnumItem, "SDL_JOYSTICK_TYPE_THROTTLE")]
		[NativeName(NativeNameType.Value, "9")]
		Throttle = unchecked(9),
		[NativeName(NativeNameType.EnumItem, "SDL_JOYSTICK_TYPE_COUNT")]
		[NativeName(NativeNameType.Value, "10")]
		Count = unchecked(10),
	}
}
