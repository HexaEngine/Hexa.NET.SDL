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
	[Flags]
	public enum SDLJoystickType : int
	{
		Unknown = unchecked(0),
		Gamepad = unchecked(1),
		Wheel = unchecked(2),
		ArcadeStick = unchecked(3),
		FlightStick = unchecked(4),
		DancePad = unchecked(5),
		Guitar = unchecked(6),
		DrumKit = unchecked(7),
		ArcadePad = unchecked(8),
		Throttle = unchecked(9),
		Count = unchecked(10),
	}
}
