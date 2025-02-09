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
	/// Individual button data.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLMessageBoxButtonData
	{
		/// <summary>
		/// SDL_MessageBoxButtonFlags <br/>
		/// </summary>
		public uint Flags;

		/// <summary>
		/// User defined button id (value returned via SDL_ShowMessageBox) <br/>
		/// </summary>
		public int Buttonid;

		/// <summary>
		/// The UTF-8 button text <br/>
		/// </summary>
		public unsafe byte* Text;


		public unsafe SDLMessageBoxButtonData(uint flags = default, int buttonid = default, byte* text = default)
		{
			Flags = flags;
			Buttonid = buttonid;
			Text = text;
		}


	}

}
