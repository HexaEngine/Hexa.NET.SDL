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
	/// A structure containing a template for a Condition effect.<br/>
	/// The struct handles the following effects:<br/>
	/// - SDL_HAPTIC_SPRING: Effect based on axes position.<br/>
	/// - SDL_HAPTIC_DAMPER: Effect based on axes velocity.<br/>
	/// - SDL_HAPTIC_INERTIA: Effect based on axes acceleration.<br/>
	/// - SDL_HAPTIC_FRICTION: Effect based on axes movement.<br/>
	/// Direction is handled by condition internals instead of a direction member.<br/>
	/// The condition effect specific members have three parameters. The first<br/>
	/// refers to the X axis, the second refers to the Y axis and the third refers<br/>
	/// to the Z axis. The right terms refer to the positive side of the axis and<br/>
	/// the left terms refer to the negative side of the axis. Please refer to the<br/>
	/// SDL_HapticDirection diagram for which side is positive and which is<br/>
	/// negative.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_HapticCondition")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLHapticCondition
	{
		/// <summary>
		/// SDL_HAPTIC_SPRING, SDL_HAPTIC_DAMPER,<br/>
		/// SDL_HAPTIC_INERTIA or SDL_HAPTIC_FRICTION <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "type")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Type;

		/// <summary>
		/// Direction of the effect. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "direction")]
		[NativeName(NativeNameType.Type, "SDL_HapticDirection")]
		public SDLHapticDirection Direction;

		/// <summary>
		/// Duration of the effect. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "length")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Length;

		/// <summary>
		/// Delay before starting the effect. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "delay")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Delay;

		/// <summary>
		/// Button that triggers the effect. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "button")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Button;

		/// <summary>
		/// How soon it can be triggered again after button. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "interval")]
		[NativeName(NativeNameType.Type, "Uint16")]
		public ushort Interval;

		/// <summary>
		/// Level when joystick is to the positive side; max 0xFFFF. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "right_sat")]
		[NativeName(NativeNameType.Type, "Uint16[3]")]
		public ushort RightSat_0;
		public ushort RightSat_1;
		public ushort RightSat_2;

		/// <summary>
		/// Level when joystick is to the negative side; max 0xFFFF. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "left_sat")]
		[NativeName(NativeNameType.Type, "Uint16[3]")]
		public ushort LeftSat_0;
		public ushort LeftSat_1;
		public ushort LeftSat_2;

		/// <summary>
		/// How fast to increase the force towards the positive side. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "right_coeff")]
		[NativeName(NativeNameType.Type, "Sint16[3]")]
		public short RightCoeff_0;
		public short RightCoeff_1;
		public short RightCoeff_2;

		/// <summary>
		/// How fast to increase the force towards the negative side. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "left_coeff")]
		[NativeName(NativeNameType.Type, "Sint16[3]")]
		public short LeftCoeff_0;
		public short LeftCoeff_1;
		public short LeftCoeff_2;

		/// <summary>
		/// Size of the dead zone; max 0xFFFF: whole axis-range when 0-centered. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "deadband")]
		[NativeName(NativeNameType.Type, "Uint16[3]")]
		public ushort Deadband_0;
		public ushort Deadband_1;
		public ushort Deadband_2;

		/// <summary>
		/// Position of the dead zone. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "center")]
		[NativeName(NativeNameType.Type, "Sint16[3]")]
		public short Center_0;
		public short Center_1;
		public short Center_2;


		public unsafe SDLHapticCondition(ushort type = default, SDLHapticDirection direction = default, uint length = default, ushort delay = default, ushort button = default, ushort interval = default, ushort* rightSat = default, ushort* leftSat = default, short* rightCoeff = default, short* leftCoeff = default, ushort* deadband = default, short* center = default)
		{
			Type = type;
			Direction = direction;
			Length = length;
			Delay = delay;
			Button = button;
			Interval = interval;
			if (rightSat != default(ushort*))
			{
				RightSat_0 = rightSat[0];
				RightSat_1 = rightSat[1];
				RightSat_2 = rightSat[2];
			}
			if (leftSat != default(ushort*))
			{
				LeftSat_0 = leftSat[0];
				LeftSat_1 = leftSat[1];
				LeftSat_2 = leftSat[2];
			}
			if (rightCoeff != default(short*))
			{
				RightCoeff_0 = rightCoeff[0];
				RightCoeff_1 = rightCoeff[1];
				RightCoeff_2 = rightCoeff[2];
			}
			if (leftCoeff != default(short*))
			{
				LeftCoeff_0 = leftCoeff[0];
				LeftCoeff_1 = leftCoeff[1];
				LeftCoeff_2 = leftCoeff[2];
			}
			if (deadband != default(ushort*))
			{
				Deadband_0 = deadband[0];
				Deadband_1 = deadband[1];
				Deadband_2 = deadband[2];
			}
			if (center != default(short*))
			{
				Center_0 = center[0];
				Center_1 = center[1];
				Center_2 = center[2];
			}
		}

		public unsafe SDLHapticCondition(ushort type = default, SDLHapticDirection direction = default, uint length = default, ushort delay = default, ushort button = default, ushort interval = default, Span<ushort> rightSat = default, Span<ushort> leftSat = default, Span<short> rightCoeff = default, Span<short> leftCoeff = default, Span<ushort> deadband = default, Span<short> center = default)
		{
			Type = type;
			Direction = direction;
			Length = length;
			Delay = delay;
			Button = button;
			Interval = interval;
			if (rightSat != default(Span<ushort>))
			{
				RightSat_0 = rightSat[0];
				RightSat_1 = rightSat[1];
				RightSat_2 = rightSat[2];
			}
			if (leftSat != default(Span<ushort>))
			{
				LeftSat_0 = leftSat[0];
				LeftSat_1 = leftSat[1];
				LeftSat_2 = leftSat[2];
			}
			if (rightCoeff != default(Span<short>))
			{
				RightCoeff_0 = rightCoeff[0];
				RightCoeff_1 = rightCoeff[1];
				RightCoeff_2 = rightCoeff[2];
			}
			if (leftCoeff != default(Span<short>))
			{
				LeftCoeff_0 = leftCoeff[0];
				LeftCoeff_1 = leftCoeff[1];
				LeftCoeff_2 = leftCoeff[2];
			}
			if (deadband != default(Span<ushort>))
			{
				Deadband_0 = deadband[0];
				Deadband_1 = deadband[1];
				Deadband_2 = deadband[2];
			}
			if (center != default(Span<short>))
			{
				Center_0 = center[0];
				Center_1 = center[1];
				Center_2 = center[2];
			}
		}


	}

}
