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
	/// A structure containing a template for a Constant effect.<br/>
	/// This struct is exclusively for the SDL_HAPTIC_CONSTANT effect.<br/>
	/// A constant effect applies a constant force in the specified direction to<br/>
	/// the joystick.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLHapticConstant
	{
		/// <summary>
		/// SDL_HAPTIC_CONSTANT <br/>
		/// </summary>
		public ushort Type;

		/// <summary>
		/// Direction of the effect. <br/>
		/// </summary>
		public SDLHapticDirection Direction;

		/// <summary>
		/// Duration of the effect. <br/>
		/// </summary>
		public uint Length;

		/// <summary>
		/// Delay before starting the effect. <br/>
		/// </summary>
		public ushort Delay;

		/// <summary>
		/// Button that triggers the effect. <br/>
		/// </summary>
		public ushort Button;

		/// <summary>
		/// How soon it can be triggered again after button. <br/>
		/// </summary>
		public ushort Interval;

		/// <summary>
		/// Strength of the constant effect. <br/>
		/// </summary>
		public short Level;

		/// <summary>
		/// Duration of the attack. <br/>
		/// </summary>
		public ushort AttackLength;

		/// <summary>
		/// Level at the start of the attack. <br/>
		/// </summary>
		public ushort AttackLevel;

		/// <summary>
		/// Duration of the fade. <br/>
		/// </summary>
		public ushort FadeLength;

		/// <summary>
		/// Level at the end of the fade. <br/>
		/// </summary>
		public ushort FadeLevel;


		public unsafe SDLHapticConstant(ushort type = default, SDLHapticDirection direction = default, uint length = default, ushort delay = default, ushort button = default, ushort interval = default, short level = default, ushort attackLength = default, ushort attackLevel = default, ushort fadeLength = default, ushort fadeLevel = default)
		{
			Type = type;
			Direction = direction;
			Length = length;
			Delay = delay;
			Button = button;
			Interval = interval;
			Level = level;
			AttackLength = attackLength;
			AttackLevel = attackLevel;
			FadeLength = fadeLength;
			FadeLevel = fadeLevel;
		}


	}

}
