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
	/// RGB value used in a message box color scheme<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_MessageBoxColor")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLMessageBoxColor
	{
		[NativeName(NativeNameType.Field, "r")]
		[NativeName(NativeNameType.Type, "Uint8")]
		public byte R;
		[NativeName(NativeNameType.Field, "g")]
		[NativeName(NativeNameType.Type, "Uint8")]
		public byte G;
		[NativeName(NativeNameType.Field, "b")]
		[NativeName(NativeNameType.Type, "Uint8")]
		public byte B;

		public unsafe SDLMessageBoxColor(byte r = default, byte g = default, byte b = default)
		{
			R = r;
			G = g;
			B = b;
		}


	}

}
