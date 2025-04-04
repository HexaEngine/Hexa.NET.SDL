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
	/// Specifies the pixel format of a texture.<br/>
	/// Texture format support varies depending on driver, hardware, and usage<br/>
	/// flags. In general, you should use SDL_GPUTextureSupportsFormat to query if<br/>
	/// a format is supported before using it. However, there are a few guaranteed<br/>
	/// formats.<br/>
	/// FIXME: Check universal support for 32-bit component formats FIXME: Check<br/>
	/// universal support for SIMULTANEOUS_READ_WRITE<br/>
	/// For SAMPLER usage, the following formats are universally supported:<br/>
	/// - R8G8B8A8_UNORM<br/>
	/// - B8G8R8A8_UNORM<br/>
	/// - R8_UNORM<br/>
	/// - R8_SNORM<br/>
	/// - R8G8_UNORM<br/>
	/// - R8G8_SNORM<br/>
	/// - R8G8B8A8_SNORM<br/>
	/// - R16_FLOAT<br/>
	/// - R16G16_FLOAT<br/>
	/// - R16G16B16A16_FLOAT<br/>
	/// - R32_FLOAT<br/>
	/// - R32G32_FLOAT<br/>
	/// - R32G32B32A32_FLOAT<br/>
	/// - R11G11B10_UFLOAT<br/>
	/// - R8G8B8A8_UNORM_SRGB<br/>
	/// - B8G8R8A8_UNORM_SRGB<br/>
	/// - D16_UNORM<br/>
	/// For COLOR_TARGET usage, the following formats are universally supported:<br/>
	/// - R8G8B8A8_UNORM<br/>
	/// - B8G8R8A8_UNORM<br/>
	/// - R8_UNORM<br/>
	/// - R16_FLOAT<br/>
	/// - R16G16_FLOAT<br/>
	/// - R16G16B16A16_FLOAT<br/>
	/// - R32_FLOAT<br/>
	/// - R32G32_FLOAT<br/>
	/// - R32G32B32A32_FLOAT<br/>
	/// - R8_UINT<br/>
	/// - R8G8_UINT<br/>
	/// - R8G8B8A8_UINT<br/>
	/// - R16_UINT<br/>
	/// - R16G16_UINT<br/>
	/// - R16G16B16A16_UINT<br/>
	/// - R8_INT<br/>
	/// - R8G8_INT<br/>
	/// - R8G8B8A8_INT<br/>
	/// - R16_INT<br/>
	/// - R16G16_INT<br/>
	/// - R16G16B16A16_INT<br/>
	/// - R8G8B8A8_UNORM_SRGB<br/>
	/// - B8G8R8A8_UNORM_SRGB<br/>
	/// For STORAGE usages, the following formats are universally supported:<br/>
	/// - R8G8B8A8_UNORM<br/>
	/// - R8G8B8A8_SNORM<br/>
	/// - R16G16B16A16_FLOAT<br/>
	/// - R32_FLOAT<br/>
	/// - R32G32_FLOAT<br/>
	/// - R32G32B32A32_FLOAT<br/>
	/// - R8G8B8A8_UINT<br/>
	/// - R16G16B16A16_UINT<br/>
	/// - R8G8B8A8_INT<br/>
	/// - R16G16B16A16_INT<br/>
	/// For DEPTH_STENCIL_TARGET usage, the following formats are universally<br/>
	/// supported:<br/>
	/// - D16_UNORM<br/>
	/// - Either (but not necessarily both!) D24_UNORM or D32_FLOAT<br/>
	/// - Either (but not necessarily both!) D24_UNORM_S8_UINT or D32_FLOAT_S8_UINT<br/>
	/// Unless D16_UNORM is sufficient for your purposes, always check which of<br/>
	/// D24/D32 is supported before creating a depth-stencil texture!<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[Flags]
	public enum SDLGPUTextureFormat : int
	{
		Invalid = unchecked(0),
		/// <summary>
		/// Unsigned Normalized Float Color Formats <br/>
		/// </summary>
		A8Unorm = unchecked(1),

		/// <summary>
		/// Unsigned Normalized Float Color Formats <br/>
		/// </summary>
		R8Unorm = unchecked(2),

		/// <summary>
		/// Unsigned Normalized Float Color Formats <br/>
		/// </summary>
		R8G8Unorm = unchecked(3),

		/// <summary>
		/// Unsigned Normalized Float Color Formats <br/>
		/// </summary>
		R8G8B8A8Unorm = unchecked(4),

		/// <summary>
		/// Unsigned Normalized Float Color Formats <br/>
		/// </summary>
		R16Unorm = unchecked(5),

		/// <summary>
		/// Unsigned Normalized Float Color Formats <br/>
		/// </summary>
		R16G16Unorm = unchecked(6),

		/// <summary>
		/// Unsigned Normalized Float Color Formats <br/>
		/// </summary>
		R16G16B16A16Unorm = unchecked(7),

		/// <summary>
		/// Unsigned Normalized Float Color Formats <br/>
		/// </summary>
		R10G10B10A2Unorm = unchecked(8),

		/// <summary>
		/// Unsigned Normalized Float Color Formats <br/>
		/// </summary>
		B5G6R5Unorm = unchecked(9),

		/// <summary>
		/// Unsigned Normalized Float Color Formats <br/>
		/// </summary>
		B5G5R5A1Unorm = unchecked(10),

		/// <summary>
		/// Unsigned Normalized Float Color Formats <br/>
		/// </summary>
		B4G4R4A4Unorm = unchecked(11),

		/// <summary>
		/// Unsigned Normalized Float Color Formats <br/>
		/// </summary>
		B8G8R8A8Unorm = unchecked(12),

		/// <summary>
		/// Compressed Unsigned Normalized Float Color Formats <br/>
		/// </summary>
		Bc1RgbaUnorm = unchecked(13),

		/// <summary>
		/// Compressed Unsigned Normalized Float Color Formats <br/>
		/// </summary>
		Bc2RgbaUnorm = unchecked(14),

		/// <summary>
		/// Compressed Unsigned Normalized Float Color Formats <br/>
		/// </summary>
		Bc3RgbaUnorm = unchecked(15),

		/// <summary>
		/// Compressed Unsigned Normalized Float Color Formats <br/>
		/// </summary>
		Bc4RUnorm = unchecked(16),

		/// <summary>
		/// Compressed Unsigned Normalized Float Color Formats <br/>
		/// </summary>
		Bc5RgUnorm = unchecked(17),

		/// <summary>
		/// Compressed Unsigned Normalized Float Color Formats <br/>
		/// </summary>
		Bc7RgbaUnorm = unchecked(18),

		/// <summary>
		/// Compressed Signed Float Color Formats <br/>
		/// </summary>
		Bc6HRgbFloat = unchecked(19),

		/// <summary>
		/// Compressed Unsigned Float Color Formats <br/>
		/// </summary>
		Bc6HRgbUfloat = unchecked(20),

		/// <summary>
		/// Signed Normalized Float Color Formats  <br/>
		/// </summary>
		R8Snorm = unchecked(21),

		/// <summary>
		/// Signed Normalized Float Color Formats  <br/>
		/// </summary>
		R8G8Snorm = unchecked(22),

		/// <summary>
		/// Signed Normalized Float Color Formats  <br/>
		/// </summary>
		R8G8B8A8Snorm = unchecked(23),

		/// <summary>
		/// Signed Normalized Float Color Formats  <br/>
		/// </summary>
		R16Snorm = unchecked(24),

		/// <summary>
		/// Signed Normalized Float Color Formats  <br/>
		/// </summary>
		R16G16Snorm = unchecked(25),

		/// <summary>
		/// Signed Normalized Float Color Formats  <br/>
		/// </summary>
		R16G16B16A16Snorm = unchecked(26),

		/// <summary>
		/// Signed Float Color Formats <br/>
		/// </summary>
		R16Float = unchecked(27),

		/// <summary>
		/// Signed Float Color Formats <br/>
		/// </summary>
		R16G16Float = unchecked(28),

		/// <summary>
		/// Signed Float Color Formats <br/>
		/// </summary>
		R16G16B16A16Float = unchecked(29),

		/// <summary>
		/// Signed Float Color Formats <br/>
		/// </summary>
		R32Float = unchecked(30),

		/// <summary>
		/// Signed Float Color Formats <br/>
		/// </summary>
		R32G32Float = unchecked(31),

		/// <summary>
		/// Signed Float Color Formats <br/>
		/// </summary>
		R32G32B32A32Float = unchecked(32),

		/// <summary>
		/// Unsigned Float Color Formats <br/>
		/// </summary>
		R11G11B10Ufloat = unchecked(33),

		/// <summary>
		/// Unsigned Integer Color Formats <br/>
		/// </summary>
		R8Uint = unchecked(34),

		/// <summary>
		/// Unsigned Integer Color Formats <br/>
		/// </summary>
		R8G8Uint = unchecked(35),

		/// <summary>
		/// Unsigned Integer Color Formats <br/>
		/// </summary>
		R8G8B8A8Uint = unchecked(36),

		/// <summary>
		/// Unsigned Integer Color Formats <br/>
		/// </summary>
		R16Uint = unchecked(37),

		/// <summary>
		/// Unsigned Integer Color Formats <br/>
		/// </summary>
		R16G16Uint = unchecked(38),

		/// <summary>
		/// Unsigned Integer Color Formats <br/>
		/// </summary>
		R16G16B16A16Uint = unchecked(39),

		/// <summary>
		/// Unsigned Integer Color Formats <br/>
		/// </summary>
		R32Uint = unchecked(40),

		/// <summary>
		/// Unsigned Integer Color Formats <br/>
		/// </summary>
		R32G32Uint = unchecked(41),

		/// <summary>
		/// Unsigned Integer Color Formats <br/>
		/// </summary>
		R32G32B32A32Uint = unchecked(42),

		/// <summary>
		/// Signed Integer Color Formats <br/>
		/// </summary>
		R8Int = unchecked(43),

		/// <summary>
		/// Signed Integer Color Formats <br/>
		/// </summary>
		R8G8Int = unchecked(44),

		/// <summary>
		/// Signed Integer Color Formats <br/>
		/// </summary>
		R8G8B8A8Int = unchecked(45),

		/// <summary>
		/// Signed Integer Color Formats <br/>
		/// </summary>
		R16Int = unchecked(46),

		/// <summary>
		/// Signed Integer Color Formats <br/>
		/// </summary>
		R16G16Int = unchecked(47),

		/// <summary>
		/// Signed Integer Color Formats <br/>
		/// </summary>
		R16G16B16A16Int = unchecked(48),

		/// <summary>
		/// Signed Integer Color Formats <br/>
		/// </summary>
		R32Int = unchecked(49),

		/// <summary>
		/// Signed Integer Color Formats <br/>
		/// </summary>
		R32G32Int = unchecked(50),

		/// <summary>
		/// Signed Integer Color Formats <br/>
		/// </summary>
		R32G32B32A32Int = unchecked(51),

		/// <summary>
		/// SRGB Unsigned Normalized Color Formats <br/>
		/// </summary>
		R8G8B8A8UnormSrgb = unchecked(52),

		/// <summary>
		/// SRGB Unsigned Normalized Color Formats <br/>
		/// </summary>
		B8G8R8A8UnormSrgb = unchecked(53),

		/// <summary>
		/// Compressed SRGB Unsigned Normalized Color Formats <br/>
		/// </summary>
		Bc1RgbaUnormSrgb = unchecked(54),

		/// <summary>
		/// Compressed SRGB Unsigned Normalized Color Formats <br/>
		/// </summary>
		Bc2RgbaUnormSrgb = unchecked(55),

		/// <summary>
		/// Compressed SRGB Unsigned Normalized Color Formats <br/>
		/// </summary>
		Bc3RgbaUnormSrgb = unchecked(56),

		/// <summary>
		/// Compressed SRGB Unsigned Normalized Color Formats <br/>
		/// </summary>
		Bc7RgbaUnormSrgb = unchecked(57),

		/// <summary>
		/// Depth Formats <br/>
		/// </summary>
		D16Unorm = unchecked(58),

		/// <summary>
		/// Depth Formats <br/>
		/// </summary>
		D24Unorm = unchecked(59),

		/// <summary>
		/// Depth Formats <br/>
		/// </summary>
		D32Float = unchecked(60),

		/// <summary>
		/// Depth Formats <br/>
		/// </summary>
		D24UnormS8Uint = unchecked(61),

		/// <summary>
		/// Depth Formats <br/>
		/// </summary>
		D32FloatS8Uint = unchecked(62),

		/// <summary>
		/// Compressed ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc4X4Unorm = unchecked(63),

		/// <summary>
		/// Compressed ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc5X4Unorm = unchecked(64),

		/// <summary>
		/// Compressed ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc5X5Unorm = unchecked(65),

		/// <summary>
		/// Compressed ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc6X5Unorm = unchecked(66),

		/// <summary>
		/// Compressed ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc6X6Unorm = unchecked(67),

		/// <summary>
		/// Compressed ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc8X5Unorm = unchecked(68),

		/// <summary>
		/// Compressed ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc8X6Unorm = unchecked(69),

		/// <summary>
		/// Compressed ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc8X8Unorm = unchecked(70),

		/// <summary>
		/// Compressed ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc10X5Unorm = unchecked(71),

		/// <summary>
		/// Compressed ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc10X6Unorm = unchecked(72),

		/// <summary>
		/// Compressed ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc10X8Unorm = unchecked(73),

		/// <summary>
		/// Compressed ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc10X10Unorm = unchecked(74),

		/// <summary>
		/// Compressed ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc12X10Unorm = unchecked(75),

		/// <summary>
		/// Compressed ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc12X12Unorm = unchecked(76),

		/// <summary>
		/// Compressed SRGB ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc4X4UnormSrgb = unchecked(77),

		/// <summary>
		/// Compressed SRGB ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc5X4UnormSrgb = unchecked(78),

		/// <summary>
		/// Compressed SRGB ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc5X5UnormSrgb = unchecked(79),

		/// <summary>
		/// Compressed SRGB ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc6X5UnormSrgb = unchecked(80),

		/// <summary>
		/// Compressed SRGB ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc6X6UnormSrgb = unchecked(81),

		/// <summary>
		/// Compressed SRGB ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc8X5UnormSrgb = unchecked(82),

		/// <summary>
		/// Compressed SRGB ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc8X6UnormSrgb = unchecked(83),

		/// <summary>
		/// Compressed SRGB ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc8X8UnormSrgb = unchecked(84),

		/// <summary>
		/// Compressed SRGB ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc10X5UnormSrgb = unchecked(85),

		/// <summary>
		/// Compressed SRGB ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc10X6UnormSrgb = unchecked(86),

		/// <summary>
		/// Compressed SRGB ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc10X8UnormSrgb = unchecked(87),

		/// <summary>
		/// Compressed SRGB ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc10X10UnormSrgb = unchecked(88),

		/// <summary>
		/// Compressed SRGB ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc12X10UnormSrgb = unchecked(89),

		/// <summary>
		/// Compressed SRGB ASTC Normalized Float Color Formats<br/>
		/// </summary>
		Astc12X12UnormSrgb = unchecked(90),

		/// <summary>
		/// Compressed ASTC Signed Float Color Formats<br/>
		/// </summary>
		Astc4X4Float = unchecked(91),

		/// <summary>
		/// Compressed ASTC Signed Float Color Formats<br/>
		/// </summary>
		Astc5X4Float = unchecked(92),

		/// <summary>
		/// Compressed ASTC Signed Float Color Formats<br/>
		/// </summary>
		Astc5X5Float = unchecked(93),

		/// <summary>
		/// Compressed ASTC Signed Float Color Formats<br/>
		/// </summary>
		Astc6X5Float = unchecked(94),

		/// <summary>
		/// Compressed ASTC Signed Float Color Formats<br/>
		/// </summary>
		Astc6X6Float = unchecked(95),

		/// <summary>
		/// Compressed ASTC Signed Float Color Formats<br/>
		/// </summary>
		Astc8X5Float = unchecked(96),

		/// <summary>
		/// Compressed ASTC Signed Float Color Formats<br/>
		/// </summary>
		Astc8X6Float = unchecked(97),

		/// <summary>
		/// Compressed ASTC Signed Float Color Formats<br/>
		/// </summary>
		Astc8X8Float = unchecked(98),

		/// <summary>
		/// Compressed ASTC Signed Float Color Formats<br/>
		/// </summary>
		Astc10X5Float = unchecked(99),

		/// <summary>
		/// Compressed ASTC Signed Float Color Formats<br/>
		/// </summary>
		Astc10X6Float = unchecked(100),

		/// <summary>
		/// Compressed ASTC Signed Float Color Formats<br/>
		/// </summary>
		Astc10X8Float = unchecked(101),

		/// <summary>
		/// Compressed ASTC Signed Float Color Formats<br/>
		/// </summary>
		Astc10X10Float = unchecked(102),

		/// <summary>
		/// Compressed ASTC Signed Float Color Formats<br/>
		/// </summary>
		Astc12X10Float = unchecked(103),

		/// <summary>
		/// Compressed ASTC Signed Float Color Formats<br/>
		/// </summary>
		Astc12X12Float = unchecked(104),
	}
}
