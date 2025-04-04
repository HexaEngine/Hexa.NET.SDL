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
	/// Pressure-sensitive pen touched event structure (event.ptouch.*)<br/>
	/// These events come when a pen touches a surface (a tablet, etc), or lifts<br/>
	/// off from one.<br/>
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLPenTouchEvent
	{
		/// <summary>
		/// SDL_EVENT_PEN_DOWN or SDL_EVENT_PEN_UP <br/>
		/// </summary>
		public SDLEventType Type;

		public uint Reserved;
		/// <summary>
		/// In nanoseconds, populated using SDL_GetTicksNS() <br/>
		/// </summary>
		public ulong Timestamp;

		/// <summary>
		/// The window with pen focus, if any <br/>
		/// </summary>
		public uint WindowID;

		/// <summary>
		/// The pen instance id <br/>
		/// </summary>
		public uint Which;

		/// <summary>
		/// Complete pen input state at time of event <br/>
		/// </summary>
		public SDLPenInputFlags PenState;

		/// <summary>
		/// X coordinate, relative to window <br/>
		/// </summary>
		public float X;

		/// <summary>
		/// Y coordinate, relative to window <br/>
		/// </summary>
		public float Y;

		/// <summary>
		/// true if eraser end is used (not all pens support this). <br/>
		/// </summary>
		public byte Eraser;

		/// <summary>
		/// true if the pen is touching or false if the pen is lifted off <br/>
		/// </summary>
		public byte Down;


		public unsafe SDLPenTouchEvent(SDLEventType type = default, uint reserved = default, ulong timestamp = default, uint windowID = default, uint which = default, SDLPenInputFlags penState = default, float x = default, float y = default, bool eraser = default, bool down = default)
		{
			Type = type;
			Reserved = reserved;
			Timestamp = timestamp;
			WindowID = windowID;
			Which = which;
			PenState = penState;
			X = x;
			Y = y;
			Eraser = eraser ? (byte)1 : (byte)0;
			Down = down ? (byte)1 : (byte)0;
		}


	}

}
