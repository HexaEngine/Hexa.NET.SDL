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
	/// Specifies the texture format and colorspace of the swapchain textures.<br/>
	/// SDR will always be supported. Other compositions may not be supported on<br/>
	/// certain systems.<br/>
	/// It is recommended to query SDL_WindowSupportsGPUSwapchainComposition after<br/>
	/// claiming the window if you wish to change the swapchain composition from<br/>
	/// SDR.<br/>
	/// - SDR: B8G8R8A8 or R8G8B8A8 swapchain. Pixel values are in sRGB encoding.<br/>
	/// - SDR_LINEAR: B8G8R8A8_SRGB or R8G8B8A8_SRGB swapchain. Pixel values are<br/>
	/// stored in memory in sRGB encoding but accessed in shaders in "linear<br/>
	/// sRGB" encoding which is sRGB but with a linear transfer function.<br/>
	/// - HDR_EXTENDED_LINEAR: R16G16B16A16_FLOAT swapchain. Pixel values are in<br/>
	/// extended linear sRGB encoding and permits values outside of the [0, 1]<br/>
	/// range.<br/>
	/// - HDR10_ST2084: A2R10G10B10 or A2B10G10R10 swapchain. Pixel values are in<br/>
	/// BT.2020 ST2084 (PQ) encoding.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[Flags]
	public enum SDLGPUSwapchainComposition : int
	{
		Sdr = unchecked(0),
		SdrLinear = unchecked(1),
		HdrExtendedLinear = unchecked(2),
		Hdr10St2084 = unchecked(3),
	}
}
