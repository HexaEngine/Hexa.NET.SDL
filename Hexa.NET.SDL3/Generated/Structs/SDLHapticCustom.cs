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
	/// A structure containing a template for the SDL_HAPTIC_CUSTOM effect.<br/>
	/// This struct is exclusively for the SDL_HAPTIC_CUSTOM effect.<br/>
	/// A custom force feedback effect is much like a periodic effect, where the<br/>
	/// application can define its exact shape. You will have to allocate the data<br/>
	/// yourself. Data should consist of channels * samples Uint16 samples.<br/>
	/// If channels is one, the effect is rotated using the defined direction.<br/>
	/// Otherwise it uses the samples in data for the different axes.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLHapticCustom
	{
		/// <summary>
		/// SDL_HAPTIC_CUSTOM <br/>
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
		/// Axes to use, minimum of one. <br/>
		/// </summary>
		public byte Channels;

		/// <summary>
		/// Sample periods. <br/>
		/// </summary>
		public ushort Period;

		/// <summary>
		/// Amount of samples. <br/>
		/// </summary>
		public ushort Samples;

		/// <summary>
		/// Should contain channels*samples items. <br/>
		/// </summary>
		public unsafe ushort* Data;

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


		public unsafe SDLHapticCustom(ushort type = default, SDLHapticDirection direction = default, uint length = default, ushort delay = default, ushort button = default, ushort interval = default, byte channels = default, ushort period = default, ushort samples = default, ushort* data = default, ushort attackLength = default, ushort attackLevel = default, ushort fadeLength = default, ushort fadeLevel = default)
		{
			Type = type;
			Direction = direction;
			Length = length;
			Delay = delay;
			Button = button;
			Interval = interval;
			Channels = channels;
			Period = period;
			Samples = samples;
			Data = data;
			AttackLength = attackLength;
			AttackLevel = attackLevel;
			FadeLength = fadeLength;
			FadeLevel = fadeLevel;
		}


	}

}
