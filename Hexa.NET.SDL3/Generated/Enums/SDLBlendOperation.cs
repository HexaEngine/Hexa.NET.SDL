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
	/// The blend operation used when combining source and destination pixel<br/>
	/// components.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_BlendOperation")]
	[Flags]
	public enum SDLBlendOperation : int
	{
		/// <summary>
		/// dst + src: supported by all renderers <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_BLENDOPERATION_ADD")]
		[NativeName(NativeNameType.Value, "1")]
		Add = unchecked(1),

		/// <summary>
		/// src - dst : supported by D3D, OpenGL, OpenGLES, and Vulkan <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_BLENDOPERATION_SUBTRACT")]
		[NativeName(NativeNameType.Value, "2")]
		Subtract = unchecked(2),

		/// <summary>
		/// dst - src : supported by D3D, OpenGL, OpenGLES, and Vulkan <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_BLENDOPERATION_REV_SUBTRACT")]
		[NativeName(NativeNameType.Value, "3")]
		RevSubtract = unchecked(3),

		/// <summary>
		/// min(dst, src) : supported by D3D, OpenGL, OpenGLES, and Vulkan <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_BLENDOPERATION_MINIMUM")]
		[NativeName(NativeNameType.Value, "4")]
		Minimum = unchecked(4),

		/// <summary>
		/// max(dst, src) : supported by D3D, OpenGL, OpenGLES, and Vulkan <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_BLENDOPERATION_MAXIMUM")]
		[NativeName(NativeNameType.Value, "5")]
		Maximum = unchecked(5),
	}
}
