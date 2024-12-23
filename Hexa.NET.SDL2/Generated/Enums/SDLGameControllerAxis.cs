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
	/// The list of axes available from a controller<br/>
	/// Thumbstick axis values range from SDL_JOYSTICK_AXIS_MIN to SDL_JOYSTICK_AXIS_MAX,<br/>
	/// and are centered within ~8000 of zero, though advanced UI will allow users to set<br/>
	/// or autodetect the dead zone, which varies between controllers.<br/>
	/// Trigger axis values range from 0 (released) to SDL_JOYSTICK_AXIS_MAX<br/>
	/// (fully pressed) when reported by SDL_GameControllerGetAxis(). Note that this is not the<br/>
	/// same range that will be reported by the lower-level SDL_GetJoystickAxis().<br/>
	/// </summary>
	[Flags]
	public enum SDLGameControllerAxis : int
	{
		Invalid = unchecked(-1),
		Leftx = unchecked(0),
		Lefty = unchecked(1),
		Rightx = unchecked(2),
		Righty = unchecked(3),
		Triggerleft = unchecked(4),
		Triggerright = unchecked(5),
		Max = unchecked(6),
	}
}
