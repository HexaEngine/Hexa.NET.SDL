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

namespace Hexa.NET.SDL2
{
	/// <summary>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_BlendMode")]
	public enum SDLBlendMode : int
	{
		/// <summary>
		/// no blending<br/>
		/// dstRGBA = srcRGBA <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_BLENDMODE_NONE")]
		[NativeName(NativeNameType.Value, "0")]
		None = unchecked(0),

		/// <summary>
		/// alpha blending<br/>
		/// dstRGB = (srcRGB * srcA) + (dstRGB * (1-srcA))<br/>
		/// dstA = srcA + (dstA * (1-srcA)) <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_BLENDMODE_BLEND")]
		[NativeName(NativeNameType.Value, "1")]
		Blend = unchecked(1),

		/// <summary>
		/// additive blending<br/>
		/// dstRGB = (srcRGB * srcA) + dstRGB<br/>
		/// dstA = dstA <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_BLENDMODE_ADD")]
		[NativeName(NativeNameType.Value, "2")]
		Add = unchecked(2),

		/// <summary>
		/// color modulate<br/>
		/// dstRGB = srcRGB * dstRGB<br/>
		/// dstA = dstA <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_BLENDMODE_MOD")]
		[NativeName(NativeNameType.Value, "4")]
		Mod = unchecked(4),

		/// <summary>
		/// color multiply<br/>
		/// dstRGB = (srcRGB * dstRGB) + (dstRGB * (1-srcA))<br/>
		/// dstA = dstA <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_BLENDMODE_MUL")]
		[NativeName(NativeNameType.Value, "8")]
		Mul = unchecked(8),

		[NativeName(NativeNameType.EnumItem, "SDL_BLENDMODE_INVALID")]
		[NativeName(NativeNameType.Value, "2147483647")]
		Invalid = unchecked(2147483647),
	}
}
