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
	/// A structure specifying a vertex attribute.<br/>
	/// All vertex attribute locations provided to an SDL_GPUVertexInputState must<br/>
	/// be unique.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLGPUVertexAttribute
	{
		/// <summary>
		/// The shader input location index. <br/>
		/// </summary>
		public uint Location;

		/// <summary>
		/// The binding slot of the associated vertex buffer. <br/>
		/// </summary>
		public uint BufferSlot;

		/// <summary>
		/// The size and type of the attribute data. <br/>
		/// </summary>
		public SDLGPUVertexElementFormat Format;

		/// <summary>
		/// The byte offset of this attribute relative to the start of the vertex element. <br/>
		/// </summary>
		public uint Offset;


		public unsafe SDLGPUVertexAttribute(uint location = default, uint bufferSlot = default, SDLGPUVertexElementFormat format = default, uint offset = default)
		{
			Location = location;
			BufferSlot = bufferSlot;
			Format = format;
			Offset = offset;
		}


	}

}
