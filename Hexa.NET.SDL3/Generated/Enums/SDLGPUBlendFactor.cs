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
	/// Specifies a blending factor to be used when pixels in a render target are<br/>
	/// blended with existing pixels in the texture.<br/>
	/// The source color is the value written by the fragment shader. The<br/>
	/// destination color is the value currently existing in the texture.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[Flags]
	public enum SDLGPUBlendFactor : int
	{
		Invalid = unchecked(0),
		/// <summary>
		/// 0 <br/>
		/// </summary>
		Zero = unchecked(1),

		/// <summary>
		/// 1 <br/>
		/// </summary>
		One = unchecked(2),

		/// <summary>
		/// source color <br/>
		/// </summary>
		SrcColor = unchecked(3),

		/// <summary>
		/// 1 - source color <br/>
		/// </summary>
		OneMinusSrcColor = unchecked(4),

		/// <summary>
		/// destination color <br/>
		/// </summary>
		DstColor = unchecked(5),

		/// <summary>
		/// 1 - destination color <br/>
		/// </summary>
		OneMinusDstColor = unchecked(6),

		/// <summary>
		/// source alpha <br/>
		/// </summary>
		SrcAlpha = unchecked(7),

		/// <summary>
		/// 1 - source alpha <br/>
		/// </summary>
		OneMinusSrcAlpha = unchecked(8),

		/// <summary>
		/// destination alpha <br/>
		/// </summary>
		DstAlpha = unchecked(9),

		/// <summary>
		/// 1 - destination alpha <br/>
		/// </summary>
		OneMinusDstAlpha = unchecked(10),

		/// <summary>
		/// blend constant <br/>
		/// </summary>
		ConstantColor = unchecked(11),

		/// <summary>
		/// 1 - blend constant <br/>
		/// </summary>
		OneMinusConstantColor = unchecked(12),

		/// <summary>
		/// min(source alpha, 1 - destination alpha) <br/>
		/// </summary>
		SrcAlphaSaturate = unchecked(13),
	}
}
