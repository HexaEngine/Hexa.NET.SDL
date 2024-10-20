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
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_TextEditingEvent")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLTextEditingEvent
	{
		/// <summary>
		/// ::SDL_TEXTEDITING <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "type")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Type;

		/// <summary>
		/// In milliseconds, populated using SDL_GetTicks() <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "timestamp")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Timestamp;

		/// <summary>
		/// The window with keyboard focus, if any <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "windowID")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint WindowID;

		/// <summary>
		/// The editing text <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "text")]
		[NativeName(NativeNameType.Type, "char[32]")]
		public byte Text_0;
		public byte Text_1;
		public byte Text_2;
		public byte Text_3;
		public byte Text_4;
		public byte Text_5;
		public byte Text_6;
		public byte Text_7;
		public byte Text_8;
		public byte Text_9;
		public byte Text_10;
		public byte Text_11;
		public byte Text_12;
		public byte Text_13;
		public byte Text_14;
		public byte Text_15;
		public byte Text_16;
		public byte Text_17;
		public byte Text_18;
		public byte Text_19;
		public byte Text_20;
		public byte Text_21;
		public byte Text_22;
		public byte Text_23;
		public byte Text_24;
		public byte Text_25;
		public byte Text_26;
		public byte Text_27;
		public byte Text_28;
		public byte Text_29;
		public byte Text_30;
		public byte Text_31;

		/// <summary>
		/// The start cursor of selected editing text <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "start")]
		[NativeName(NativeNameType.Type, "Sint32")]
		public int Start;

		/// <summary>
		/// The length of selected editing text <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "length")]
		[NativeName(NativeNameType.Type, "Sint32")]
		public int Length;


		public unsafe SDLTextEditingEvent(uint type = default, uint timestamp = default, uint windowID = default, byte* text = default, int start = default, int length = default)
		{
			Type = type;
			Timestamp = timestamp;
			WindowID = windowID;
			if (text != default(byte*))
			{
				Text_0 = text[0];
				Text_1 = text[1];
				Text_2 = text[2];
				Text_3 = text[3];
				Text_4 = text[4];
				Text_5 = text[5];
				Text_6 = text[6];
				Text_7 = text[7];
				Text_8 = text[8];
				Text_9 = text[9];
				Text_10 = text[10];
				Text_11 = text[11];
				Text_12 = text[12];
				Text_13 = text[13];
				Text_14 = text[14];
				Text_15 = text[15];
				Text_16 = text[16];
				Text_17 = text[17];
				Text_18 = text[18];
				Text_19 = text[19];
				Text_20 = text[20];
				Text_21 = text[21];
				Text_22 = text[22];
				Text_23 = text[23];
				Text_24 = text[24];
				Text_25 = text[25];
				Text_26 = text[26];
				Text_27 = text[27];
				Text_28 = text[28];
				Text_29 = text[29];
				Text_30 = text[30];
				Text_31 = text[31];
			}
			Start = start;
			Length = length;
		}

		public unsafe SDLTextEditingEvent(uint type = default, uint timestamp = default, uint windowID = default, Span<byte> text = default, int start = default, int length = default)
		{
			Type = type;
			Timestamp = timestamp;
			WindowID = windowID;
			if (text != default(Span<byte>))
			{
				Text_0 = text[0];
				Text_1 = text[1];
				Text_2 = text[2];
				Text_3 = text[3];
				Text_4 = text[4];
				Text_5 = text[5];
				Text_6 = text[6];
				Text_7 = text[7];
				Text_8 = text[8];
				Text_9 = text[9];
				Text_10 = text[10];
				Text_11 = text[11];
				Text_12 = text[12];
				Text_13 = text[13];
				Text_14 = text[14];
				Text_15 = text[15];
				Text_16 = text[16];
				Text_17 = text[17];
				Text_18 = text[18];
				Text_19 = text[19];
				Text_20 = text[20];
				Text_21 = text[21];
				Text_22 = text[22];
				Text_23 = text[23];
				Text_24 = text[24];
				Text_25 = text[25];
				Text_26 = text[26];
				Text_27 = text[27];
				Text_28 = text[28];
				Text_29 = text[29];
				Text_30 = text[30];
				Text_31 = text[31];
			}
			Start = start;
			Length = length;
		}


	}

}