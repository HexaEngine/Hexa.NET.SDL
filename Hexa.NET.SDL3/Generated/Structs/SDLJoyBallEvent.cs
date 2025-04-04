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
	/// Joystick trackball motion event structure (event.jball.*)<br/>
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLJoyBallEvent
	{
		/// <summary>
		/// SDL_EVENT_JOYSTICK_BALL_MOTION <br/>
		/// </summary>
		public SDLEventType Type;

		public uint Reserved;
		/// <summary>
		/// In nanoseconds, populated using SDL_GetTicksNS() <br/>
		/// </summary>
		public ulong Timestamp;

		/// <summary>
		/// The joystick instance id <br/>
		/// </summary>
		public int Which;

		/// <summary>
		/// The joystick trackball index <br/>
		/// </summary>
		public byte Ball;

		public byte Padding1;
		public byte Padding2;
		public byte Padding3;
		/// <summary>
		/// The relative motion in the X direction <br/>
		/// </summary>
		public short Xrel;

		/// <summary>
		/// The relative motion in the Y direction <br/>
		/// </summary>
		public short Yrel;


		public unsafe SDLJoyBallEvent(SDLEventType type = default, uint reserved = default, ulong timestamp = default, int which = default, byte ball = default, byte padding1 = default, byte padding2 = default, byte padding3 = default, short xrel = default, short yrel = default)
		{
			Type = type;
			Reserved = reserved;
			Timestamp = timestamp;
			Which = which;
			Ball = ball;
			Padding1 = padding1;
			Padding2 = padding2;
			Padding3 = padding3;
			Xrel = xrel;
			Yrel = yrel;
		}


	}

}
