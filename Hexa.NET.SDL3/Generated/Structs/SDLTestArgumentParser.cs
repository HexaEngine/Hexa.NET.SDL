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
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLTestArgumentParser
	{
		/// <summary>
		/// !<br/>
		/// <<br/>
		/// Parse an argument. <br/>
		/// </summary>
		public unsafe void* ParseArguments;
		/// <summary>
		/// !<br/>
		/// <<br/>
		/// Finalize this argument parser. Called once before parsing the first argument. <br/>
		/// </summary>
		public unsafe void* Finalize;
		/// <summary>
		/// !<br/>
		/// <<br/>
		/// Null-terminated array of arguments. Printed when running with --help. <br/>
		/// </summary>
		public unsafe byte** Usage;

		/// <summary>
		/// !<br/>
		/// <<br/>
		/// User data, passed to all callbacks. <br/>
		/// </summary>
		public unsafe void* Data;

		/// <summary>
		/// !<br/>
		/// <<br/>
		/// Next argument parser. <br/>
		/// </summary>
		public unsafe SDLTestArgumentParser* Next;


		public unsafe SDLTestArgumentParser(SDLTestParseArgumentsFp parseArguments = default, SDLTestFinalizeArgumentParserFp finalize = default, byte** usage = default, void* data = default, SDLTestArgumentParser* next = default)
		{
			ParseArguments = (delegate*<void*, byte**, int, int>)Marshal.GetFunctionPointerForDelegate(parseArguments);
			Finalize = (delegate*<void*, void>)Marshal.GetFunctionPointerForDelegate(finalize);
			Usage = usage;
			Data = data;
			Next = next;
		}


	}

}
