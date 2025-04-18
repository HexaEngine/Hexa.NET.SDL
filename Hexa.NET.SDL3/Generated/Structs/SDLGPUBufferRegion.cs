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
	/// A structure specifying a region of a buffer.<br/>
	/// Used when transferring data to or from buffers.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLGPUBufferRegion
	{
		/// <summary>
		/// The buffer. <br/>
		/// </summary>
		public unsafe SDLGPUBuffer* Buffer;

		/// <summary>
		/// The starting byte within the buffer. <br/>
		/// </summary>
		public uint Offset;

		/// <summary>
		/// The size in bytes of the region. <br/>
		/// </summary>
		public uint Size;


		public unsafe SDLGPUBufferRegion(SDLGPUBuffer* buffer = default, uint offset = default, uint size = default)
		{
			Buffer = buffer;
			Offset = offset;
			Size = size;
		}


	}

}
