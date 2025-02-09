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
	/// Audio device event structure (event.adevice.*)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLAudioDeviceEvent
	{
		/// <summary>
		/// SDL_AUDIODEVICEADDED, or SDL_AUDIODEVICEREMOVED <br/>
		/// </summary>
		public uint Type;

		/// <summary>
		/// In milliseconds, populated using SDL_GetTicks() <br/>
		/// </summary>
		public uint Timestamp;

		/// <summary>
		/// The audio device index for the ADDED event (valid until next SDL_GetNumAudioDevices() call), SDL_AudioDeviceID for the REMOVED event <br/>
		/// </summary>
		public uint Which;

		/// <summary>
		/// zero if an output device, non-zero if a capture device. <br/>
		/// </summary>
		public byte Iscapture;

		public byte Padding1;
		public byte Padding2;
		public byte Padding3;

		public unsafe SDLAudioDeviceEvent(uint type = default, uint timestamp = default, uint which = default, byte iscapture = default, byte padding1 = default, byte padding2 = default, byte padding3 = default)
		{
			Type = type;
			Timestamp = timestamp;
			Which = which;
			Iscapture = iscapture;
			Padding1 = padding1;
			Padding2 = padding2;
			Padding3 = padding3;
		}


	}

}
