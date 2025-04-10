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
	/// The list of buttons available on a gamepad<br/>
	/// For controllers that use a diamond pattern for the face buttons, the<br/>
	/// south/east/west/north buttons below correspond to the locations in the<br/>
	/// diamond pattern. For Xbox controllers, this would be A/B/X/Y, for Nintendo<br/>
	/// Switch controllers, this would be B/A/Y/X, for PlayStation controllers this<br/>
	/// would be Cross/Circle/Square/Triangle.<br/>
	/// For controllers that don't use a diamond pattern for the face buttons, the<br/>
	/// south/east/west/north buttons indicate the buttons labeled A, B, C, D, or<br/>
	/// 1, 2, 3, 4, or for controllers that aren't labeled, they are the primary,<br/>
	/// secondary, etc. buttons.<br/>
	/// The activate action is often the south button and the cancel action is<br/>
	/// often the east button, but in some regions this is reversed, so your game<br/>
	/// should allow remapping actions based on user preferences.<br/>
	/// You can query the labels for the face buttons using<br/>
	/// SDL_GetGamepadButtonLabel()<br/>
	/// <br/>
	/// </summary>
	[Flags]
	public enum SDLGamepadButton : int
	{
		Invalid = unchecked(-1),
		/// <summary>
		/// Bottom face button (e.g. Xbox A button) <br/>
		/// </summary>
		South = unchecked(0),

		/// <summary>
		/// Right face button (e.g. Xbox B button) <br/>
		/// </summary>
		East = unchecked(1),

		/// <summary>
		/// Left face button (e.g. Xbox X button) <br/>
		/// </summary>
		West = unchecked(2),

		/// <summary>
		/// Top face button (e.g. Xbox Y button) <br/>
		/// </summary>
		North = unchecked(3),

		Back = unchecked(4),
		Guide = unchecked(5),
		Start = unchecked(6),
		LeftStick = unchecked(7),
		RightStick = unchecked(8),
		LeftShoulder = unchecked(9),
		RightShoulder = unchecked(10),
		DpadUp = unchecked(11),
		DpadDown = unchecked(12),
		DpadLeft = unchecked(13),
		DpadRight = unchecked(14),
		/// <summary>
		/// Additional button (e.g. Xbox Series X share button, PS5 microphone button, Nintendo Switch Pro capture button, Amazon Luna microphone button, Google Stadia capture button) <br/>
		/// </summary>
		Misc1 = unchecked(15),

		/// <summary>
		/// Upper or primary paddle, under your right hand (e.g. Xbox Elite paddle P1) <br/>
		/// </summary>
		RightPaddle1 = unchecked(16),

		/// <summary>
		/// Upper or primary paddle, under your left hand (e.g. Xbox Elite paddle P3) <br/>
		/// </summary>
		LeftPaddle1 = unchecked(17),

		/// <summary>
		/// Lower or secondary paddle, under your right hand (e.g. Xbox Elite paddle P2) <br/>
		/// </summary>
		RightPaddle2 = unchecked(18),

		/// <summary>
		/// Lower or secondary paddle, under your left hand (e.g. Xbox Elite paddle P4) <br/>
		/// </summary>
		LeftPaddle2 = unchecked(19),

		/// <summary>
		/// PS4/PS5 touchpad button <br/>
		/// </summary>
		Touchpad = unchecked(20),

		/// <summary>
		/// Additional button <br/>
		/// </summary>
		Misc2 = unchecked(21),

		/// <summary>
		/// Additional button <br/>
		/// </summary>
		Misc3 = unchecked(22),

		/// <summary>
		/// Additional button <br/>
		/// </summary>
		Misc4 = unchecked(23),

		/// <summary>
		/// Additional button <br/>
		/// </summary>
		Misc5 = unchecked(24),

		/// <summary>
		/// Additional button <br/>
		/// </summary>
		Misc6 = unchecked(25),

		Count = unchecked(26),
	}
}
