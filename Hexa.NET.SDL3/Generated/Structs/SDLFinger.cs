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
	/// Data about a single finger in a multitouch event.<br/>
	/// Each touch event is a collection of fingers that are simultaneously in<br/>
	/// contact with the touch device (so a "touch" can be a "multitouch," in<br/>
	/// reality), and this struct reports details of the specific fingers.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_Finger")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLFinger
	{
		/// <summary>
		/// the finger ID <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "id")]
		[NativeName(NativeNameType.Type, "SDL_FingerID")]
		public long Id;

		/// <summary>
		/// the x-axis location of the touch event, normalized (0...1) <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "x")]
		[NativeName(NativeNameType.Type, "float")]
		public float X;

		/// <summary>
		/// the y-axis location of the touch event, normalized (0...1) <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "y")]
		[NativeName(NativeNameType.Type, "float")]
		public float Y;

		/// <summary>
		/// the quantity of pressure applied, normalized (0...1) <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "pressure")]
		[NativeName(NativeNameType.Type, "float")]
		public float Pressure;


		public unsafe SDLFinger(long id = default, float x = default, float y = default, float pressure = default)
		{
			Id = id;
			X = x;
			Y = y;
			Pressure = pressure;
		}


	}

}
