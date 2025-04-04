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
	/// Pressure-sensitive pen proximity event structure (event.pmotion.*)<br/>
	/// When a pen becomes visible to the system (it is close enough to a tablet,<br/>
	/// etc), SDL will send an SDL_EVENT_PEN_PROXIMITY_IN event with the new pen's<br/>
	/// ID. This ID is valid until the pen leaves proximity again (has been removed<br/>
	/// from the tablet's area, the tablet has been unplugged, etc). If the same<br/>
	/// pen reenters proximity again, it will be given a new ID.<br/>
	/// Note that "proximity" means "close enough for the tablet to know the tool<br/>
	/// is there." The pen touching and lifting off from the tablet while not<br/>
	/// leaving the area are handled by SDL_EVENT_PEN_DOWN and SDL_EVENT_PEN_UP.<br/>
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLPenProximityEvent
	{
		/// <summary>
		/// SDL_EVENT_PEN_PROXIMITY_IN or SDL_EVENT_PEN_PROXIMITY_OUT <br/>
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


		public unsafe SDLPenProximityEvent(SDLEventType type = default, uint reserved = default, ulong timestamp = default, uint windowID = default, uint which = default)
		{
			Type = type;
			Reserved = reserved;
			Timestamp = timestamp;
			WindowID = windowID;
			Which = which;
		}


	}

}
