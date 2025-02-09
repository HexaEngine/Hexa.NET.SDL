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
	/// Window state change event data (event.window.*)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLWindowEvent
	{
		/// <summary>
		/// SDL_WINDOWEVENT <br/>
		/// </summary>
		public uint Type;

		/// <summary>
		/// In milliseconds, populated using SDL_GetTicks() <br/>
		/// </summary>
		public uint Timestamp;

		/// <summary>
		/// The associated window <br/>
		/// </summary>
		public uint WindowID;

		/// <summary>
		/// SDL_WindowEventID <br/>
		/// </summary>
		public byte Event;

		public byte Padding1;
		public byte Padding2;
		public byte Padding3;
		/// <summary>
		/// event dependent data <br/>
		/// </summary>
		public int Data1;

		/// <summary>
		/// event dependent data <br/>
		/// </summary>
		public int Data2;


		public unsafe SDLWindowEvent(uint type = default, uint timestamp = default, uint windowID = default, byte evnt = default, byte padding1 = default, byte padding2 = default, byte padding3 = default, int data1 = default, int data2 = default)
		{
			Type = type;
			Timestamp = timestamp;
			WindowID = windowID;
			Event = evnt;
			Padding1 = padding1;
			Padding2 = padding2;
			Padding3 = padding3;
			Data1 = data1;
			Data2 = data2;
		}


	}

}
