// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;

namespace Hexa.NET.SDL3
{
	/// <summary>
	/// Specifies the rate at which vertex attributes are pulled from buffers.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[Flags]
	public enum SDLGPUVertexInputRate : int
	{
		/// <summary>
		/// Attribute addressing is a function of the vertex index. <br/>
		/// </summary>
		Vertex = unchecked(0),

		/// <summary>
		/// Attribute addressing is a function of the instance index. <br/>
		/// </summary>
		Instance = unchecked(1),
	}
}
