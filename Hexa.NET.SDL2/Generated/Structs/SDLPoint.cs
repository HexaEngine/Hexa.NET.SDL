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
	/// The structure that defines a point (integer)<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_Point")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLPoint
	{
		[NativeName(NativeNameType.Field, "x")]
		[NativeName(NativeNameType.Type, "int")]
		public int X;
		[NativeName(NativeNameType.Field, "y")]
		[NativeName(NativeNameType.Type, "int")]
		public int Y;

		public unsafe SDLPoint(int x = default, int y = default)
		{
			X = x;
			Y = y;
		}


	}

}
