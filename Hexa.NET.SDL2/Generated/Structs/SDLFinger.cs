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
	[NativeName(NativeNameType.StructOrClass, "SDL_Finger")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLFinger
	{
		[NativeName(NativeNameType.Field, "id")]
		[NativeName(NativeNameType.Type, "SDL_FingerID")]
		public long Id;
		[NativeName(NativeNameType.Field, "x")]
		[NativeName(NativeNameType.Type, "float")]
		public float X;
		[NativeName(NativeNameType.Field, "y")]
		[NativeName(NativeNameType.Type, "float")]
		public float Y;
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
