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
	/// A set of indexed colors representing a palette.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_Palette")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLPalette
	{
		/// <summary>
		/// number of elements in `colors`. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "ncolors")]
		[NativeName(NativeNameType.Type, "int")]
		public int Ncolors;

		/// <summary>
		/// an array of colors, `ncolors` long. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "colors")]
		[NativeName(NativeNameType.Type, "SDL_Color *")]
		public unsafe SDLColor* Colors;

		/// <summary>
		/// internal use only, do not touch. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "version")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Version;

		/// <summary>
		/// internal use only, do not touch. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "refcount")]
		[NativeName(NativeNameType.Type, "int")]
		public int Refcount;


		public unsafe SDLPalette(int ncolors = default, SDLColor* colors = default, uint version = default, int refcount = default)
		{
			Ncolors = ncolors;
			Colors = colors;
			Version = version;
			Refcount = refcount;
		}


	}

}