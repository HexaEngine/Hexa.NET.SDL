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
	/// Specifies a comparison operator for depth, stencil and sampler operations.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[Flags]
	public enum SDLGPUCompareOp : int
	{
		Invalid = unchecked(0),
		/// <summary>
		/// The comparison always evaluates false. <br/>
		/// </summary>
		Never = unchecked(1),

		/// <summary>
		/// The comparison evaluates reference <br/>
		/// <<br/>
		/// test. <br/>
		/// </summary>
		Less = unchecked(2),

		/// <summary>
		/// The comparison evaluates reference == test. <br/>
		/// </summary>
		Equal = unchecked(3),

		/// <summary>
		/// The comparison evaluates reference <br/>
		/// <<br/>
		/// = test. <br/>
		/// </summary>
		LessOrEqual = unchecked(4),

		/// <summary>
		/// The comparison evaluates reference > test. <br/>
		/// </summary>
		Greater = unchecked(5),

		/// <summary>
		/// The comparison evaluates reference != test. <br/>
		/// </summary>
		NotEqual = unchecked(6),

		/// <summary>
		/// The comparison evalutes reference >= test. <br/>
		/// </summary>
		GreaterOrEqual = unchecked(7),

		/// <summary>
		/// The comparison always evaluates true. <br/>
		/// </summary>
		Always = unchecked(8),
	}
}
