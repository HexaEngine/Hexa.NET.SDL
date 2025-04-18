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
	/// The list of axes available on a gamepad<br/>
	/// Thumbstick axis values range from SDL_JOYSTICK_AXIS_MIN to<br/>
	/// SDL_JOYSTICK_AXIS_MAX, and are centered within ~8000 of zero, though<br/>
	/// advanced UI will allow users to set or autodetect the dead zone, which<br/>
	/// varies between gamepads.<br/>
	/// Trigger axis values range from 0 (released) to SDL_JOYSTICK_AXIS_MAX (fully<br/>
	/// pressed) when reported by SDL_GetGamepadAxis(). Note that this is not the<br/>
	/// same range that will be reported by the lower-level SDL_GetJoystickAxis().<br/>
	/// <br/>
	/// </summary>
	[Flags]
	public enum SDLGamepadAxis : int
	{
		Invalid = unchecked(-1),
		Leftx = unchecked(0),
		Lefty = unchecked(1),
		Rightx = unchecked(2),
		Righty = unchecked(3),
		LeftTrigger = unchecked(4),
		RightTrigger = unchecked(5),
		Count = unchecked(6),
	}
}
