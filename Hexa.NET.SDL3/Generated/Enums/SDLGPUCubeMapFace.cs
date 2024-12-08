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
	/// Specifies the face of a cube map.<br/>
	/// Can be passed in as the layer field in texture-related structs.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_GPUCubeMapFace")]
	[Flags]
	public enum SDLGPUCubeMapFace : int
	{
		[NativeName(NativeNameType.EnumItem, "SDL_GPU_CUBEMAPFACE_POSITIVEX")]
		[NativeName(NativeNameType.Value, "0")]
		Positivex = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "SDL_GPU_CUBEMAPFACE_NEGATIVEX")]
		[NativeName(NativeNameType.Value, "1")]
		Negativex = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "SDL_GPU_CUBEMAPFACE_POSITIVEY")]
		[NativeName(NativeNameType.Value, "2")]
		Positivey = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "SDL_GPU_CUBEMAPFACE_NEGATIVEY")]
		[NativeName(NativeNameType.Value, "3")]
		Negativey = unchecked(3),
		[NativeName(NativeNameType.EnumItem, "SDL_GPU_CUBEMAPFACE_POSITIVEZ")]
		[NativeName(NativeNameType.Value, "4")]
		Positivez = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "SDL_GPU_CUBEMAPFACE_NEGATIVEZ")]
		[NativeName(NativeNameType.Value, "5")]
		Negativez = unchecked(5),
	}
}