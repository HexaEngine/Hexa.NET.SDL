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

namespace Hexa.NET.SDL2
{
	/// <summary>
	/// Mouse motion event structure (event.motion.*)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLMouseMotionEvent
	{
		/// <summary>
		/// SDL_MOUSEMOTION <br/>
		/// </summary>
		public uint Type;

		/// <summary>
		/// In milliseconds, populated using SDL_GetTicks() <br/>
		/// </summary>
		public uint Timestamp;

		/// <summary>
		/// The window with mouse focus, if any <br/>
		/// </summary>
		public uint WindowID;

		/// <summary>
		/// The mouse instance id, or SDL_TOUCH_MOUSEID <br/>
		/// </summary>
		public uint Which;

		/// <summary>
		/// The current button state <br/>
		/// </summary>
		public uint State;

		/// <summary>
		/// X coordinate, relative to window <br/>
		/// </summary>
		public int X;

		/// <summary>
		/// Y coordinate, relative to window <br/>
		/// </summary>
		public int Y;

		/// <summary>
		/// The relative motion in the X direction <br/>
		/// </summary>
		public int Xrel;

		/// <summary>
		/// The relative motion in the Y direction <br/>
		/// </summary>
		public int Yrel;


		public unsafe SDLMouseMotionEvent(uint type = default, uint timestamp = default, uint windowID = default, uint which = default, uint state = default, int x = default, int y = default, int xrel = default, int yrel = default)
		{
			Type = type;
			Timestamp = timestamp;
			WindowID = windowID;
			Which = which;
			State = state;
			X = x;
			Y = y;
			Xrel = xrel;
			Yrel = yrel;
		}


	}

}
