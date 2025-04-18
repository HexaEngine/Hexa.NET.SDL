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
	/// A structure specifying the parameters of an indexed dispatch command.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLGPUIndirectDispatchCommand
	{
		/// <summary>
		/// The number of local workgroups to dispatch in the X dimension. <br/>
		/// </summary>
		public uint GroupcountX;

		/// <summary>
		/// The number of local workgroups to dispatch in the Y dimension. <br/>
		/// </summary>
		public uint GroupcountY;

		/// <summary>
		/// The number of local workgroups to dispatch in the Z dimension. <br/>
		/// </summary>
		public uint GroupcountZ;


		public unsafe SDLGPUIndirectDispatchCommand(uint groupcountX = default, uint groupcountY = default, uint groupcountZ = default)
		{
			GroupcountX = groupcountX;
			GroupcountY = groupcountY;
			GroupcountZ = groupcountZ;
		}


	}

}
