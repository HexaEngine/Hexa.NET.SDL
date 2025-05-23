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
	/// Mouse wheel event structure (event.wheel.*)<br/>
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLMouseWheelEvent
	{
		/// <summary>
		/// SDL_EVENT_MOUSE_WHEEL <br/>
		/// </summary>
		public SDLEventType Type;

		public uint Reserved;
		/// <summary>
		/// In nanoseconds, populated using SDL_GetTicksNS() <br/>
		/// </summary>
		public ulong Timestamp;

		/// <summary>
		/// The window with mouse focus, if any <br/>
		/// </summary>
		public uint WindowID;

		/// <summary>
		/// The mouse instance id in relative mode or 0 <br/>
		/// </summary>
		public uint Which;

		/// <summary>
		/// The amount scrolled horizontally, positive to the right and negative to the left <br/>
		/// </summary>
		public float X;

		/// <summary>
		/// The amount scrolled vertically, positive away from the user and negative toward the user <br/>
		/// </summary>
		public float Y;

		/// <summary>
		/// Set to one of the SDL_MOUSEWHEEL_* defines. When FLIPPED the values in X and Y will be opposite. Multiply by -1 to change them back <br/>
		/// </summary>
		public SDLMouseWheelDirection Direction;

		/// <summary>
		/// X coordinate, relative to window <br/>
		/// </summary>
		public float MouseX;

		/// <summary>
		/// Y coordinate, relative to window <br/>
		/// </summary>
		public float MouseY;

		/// <summary>
		/// The amount scrolled horizontally, accumulated to whole scroll "ticks" (added in 3.2.12) <br/>
		/// </summary>
		public int IntegerX;

		/// <summary>
		/// The amount scrolled vertically, accumulated to whole scroll "ticks" (added in 3.2.12) <br/>
		/// </summary>
		public int IntegerY;


		public unsafe SDLMouseWheelEvent(SDLEventType type = default, uint reserved = default, ulong timestamp = default, uint windowID = default, uint which = default, float x = default, float y = default, SDLMouseWheelDirection direction = default, float mouseX = default, float mouseY = default, int integerX = default, int integerY = default)
		{
			Type = type;
			Reserved = reserved;
			Timestamp = timestamp;
			WindowID = windowID;
			Which = which;
			X = x;
			Y = y;
			Direction = direction;
			MouseX = mouseX;
			MouseY = mouseY;
			IntegerX = integerX;
			IntegerY = integerY;
		}


	}

}
