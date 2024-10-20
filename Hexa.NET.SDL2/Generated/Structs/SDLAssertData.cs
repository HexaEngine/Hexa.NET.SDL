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
	[NativeName(NativeNameType.StructOrClass, "SDL_AssertData")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLAssertData
	{
		[NativeName(NativeNameType.Field, "always_ignore")]
		[NativeName(NativeNameType.Type, "int")]
		public int AlwaysIgnore;
		[NativeName(NativeNameType.Field, "trigger_count")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint TriggerCount;
		[NativeName(NativeNameType.Field, "condition")]
		[NativeName(NativeNameType.Type, "const char*")]
		public unsafe byte* Condition;
		[NativeName(NativeNameType.Field, "filename")]
		[NativeName(NativeNameType.Type, "const char*")]
		public unsafe byte* Filename;
		[NativeName(NativeNameType.Field, "linenum")]
		[NativeName(NativeNameType.Type, "int")]
		public int Linenum;
		[NativeName(NativeNameType.Field, "function")]
		[NativeName(NativeNameType.Type, "const char*")]
		public unsafe byte* Function;
		[NativeName(NativeNameType.Field, "next")]
		[NativeName(NativeNameType.Type, "const SDL_AssertData*")]
		public unsafe SDLAssertData* Next;

		public unsafe SDLAssertData(int alwaysIgnore = default, uint triggerCount = default, byte* condition = default, byte* filename = default, int linenum = default, byte* function = default, SDLAssertData* next = default)
		{
			AlwaysIgnore = alwaysIgnore;
			TriggerCount = triggerCount;
			Condition = condition;
			Filename = filename;
			Linenum = linenum;
			Function = function;
			Next = next;
		}


	}

}