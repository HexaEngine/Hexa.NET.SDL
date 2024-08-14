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
	/// Note: If you modify this list, update SDL_GetPixelFormatName() <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_PixelFormatEnum")]
	public enum SDLPixelFormatEnum : int
	{
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_UNKNOWN")]
		[NativeName(NativeNameType.Value, "0")]
		Unknown = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_INDEX1LSB")]
		[NativeName(NativeNameType.Value, "286261504")]
		Index1Lsb = unchecked(286261504),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_INDEX1MSB")]
		[NativeName(NativeNameType.Value, "287310080")]
		Index1Msb = unchecked(287310080),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_INDEX2LSB")]
		[NativeName(NativeNameType.Value, "470811136")]
		Index2Lsb = unchecked(470811136),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_INDEX2MSB")]
		[NativeName(NativeNameType.Value, "471859712")]
		Index2Msb = unchecked(471859712),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_INDEX4LSB")]
		[NativeName(NativeNameType.Value, "303039488")]
		Index4Lsb = unchecked(303039488),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_INDEX4MSB")]
		[NativeName(NativeNameType.Value, "304088064")]
		Index4Msb = unchecked(304088064),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_INDEX8")]
		[NativeName(NativeNameType.Value, "318769153")]
		Index8 = unchecked(318769153),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_RGB332")]
		[NativeName(NativeNameType.Value, "336660481")]
		Rgb332 = unchecked(336660481),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_XRGB4444")]
		[NativeName(NativeNameType.Value, "353504258")]
		Xrgb4444 = unchecked(353504258),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_RGB444")]
		[NativeName(NativeNameType.Value, "SDL_PIXELFORMAT_XRGB4444")]
		Rgb444 = Xrgb4444,
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_XBGR4444")]
		[NativeName(NativeNameType.Value, "357698562")]
		Xbgr4444 = unchecked(357698562),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_BGR444")]
		[NativeName(NativeNameType.Value, "SDL_PIXELFORMAT_XBGR4444")]
		Bgr444 = Xbgr4444,
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_XRGB1555")]
		[NativeName(NativeNameType.Value, "353570562")]
		Xrgb1555 = unchecked(353570562),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_RGB555")]
		[NativeName(NativeNameType.Value, "SDL_PIXELFORMAT_XRGB1555")]
		Rgb555 = Xrgb1555,
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_XBGR1555")]
		[NativeName(NativeNameType.Value, "357764866")]
		Xbgr1555 = unchecked(357764866),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_BGR555")]
		[NativeName(NativeNameType.Value, "SDL_PIXELFORMAT_XBGR1555")]
		Bgr555 = Xbgr1555,
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_ARGB4444")]
		[NativeName(NativeNameType.Value, "355602434")]
		Argb4444 = unchecked(355602434),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_RGBA4444")]
		[NativeName(NativeNameType.Value, "356651010")]
		Rgba4444 = unchecked(356651010),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_ABGR4444")]
		[NativeName(NativeNameType.Value, "359796738")]
		Abgr4444 = unchecked(359796738),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_BGRA4444")]
		[NativeName(NativeNameType.Value, "360845314")]
		Bgra4444 = unchecked(360845314),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_ARGB1555")]
		[NativeName(NativeNameType.Value, "355667970")]
		Argb1555 = unchecked(355667970),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_RGBA5551")]
		[NativeName(NativeNameType.Value, "356782082")]
		Rgba5551 = unchecked(356782082),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_ABGR1555")]
		[NativeName(NativeNameType.Value, "359862274")]
		Abgr1555 = unchecked(359862274),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_BGRA5551")]
		[NativeName(NativeNameType.Value, "360976386")]
		Bgra5551 = unchecked(360976386),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_RGB565")]
		[NativeName(NativeNameType.Value, "353701890")]
		Rgb565 = unchecked(353701890),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_BGR565")]
		[NativeName(NativeNameType.Value, "357896194")]
		Bgr565 = unchecked(357896194),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_RGB24")]
		[NativeName(NativeNameType.Value, "386930691")]
		Rgb24 = unchecked(386930691),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_BGR24")]
		[NativeName(NativeNameType.Value, "390076419")]
		Bgr24 = unchecked(390076419),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_XRGB8888")]
		[NativeName(NativeNameType.Value, "370546692")]
		Xrgb8888 = unchecked(370546692),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_RGB888")]
		[NativeName(NativeNameType.Value, "SDL_PIXELFORMAT_XRGB8888")]
		Rgb888 = Xrgb8888,
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_RGBX8888")]
		[NativeName(NativeNameType.Value, "371595268")]
		Rgbx8888 = unchecked(371595268),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_XBGR8888")]
		[NativeName(NativeNameType.Value, "374740996")]
		Xbgr8888 = unchecked(374740996),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_BGR888")]
		[NativeName(NativeNameType.Value, "SDL_PIXELFORMAT_XBGR8888")]
		Bgr888 = Xbgr8888,
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_BGRX8888")]
		[NativeName(NativeNameType.Value, "375789572")]
		Bgrx8888 = unchecked(375789572),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_ARGB8888")]
		[NativeName(NativeNameType.Value, "372645892")]
		Argb8888 = unchecked(372645892),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_RGBA8888")]
		[NativeName(NativeNameType.Value, "373694468")]
		Rgba8888 = unchecked(373694468),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_ABGR8888")]
		[NativeName(NativeNameType.Value, "376840196")]
		Abgr8888 = unchecked(376840196),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_BGRA8888")]
		[NativeName(NativeNameType.Value, "377888772")]
		Bgra8888 = unchecked(377888772),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_ARGB2101010")]
		[NativeName(NativeNameType.Value, "372711428")]
		Argb2101010 = unchecked(372711428),
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_RGBA32")]
		[NativeName(NativeNameType.Value, "SDL_PIXELFORMAT_ABGR8888")]
		Rgba32 = Abgr8888,
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_ARGB32")]
		[NativeName(NativeNameType.Value, "SDL_PIXELFORMAT_BGRA8888")]
		Argb32 = Bgra8888,
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_BGRA32")]
		[NativeName(NativeNameType.Value, "SDL_PIXELFORMAT_ARGB8888")]
		Bgra32 = Argb8888,
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_ABGR32")]
		[NativeName(NativeNameType.Value, "SDL_PIXELFORMAT_RGBA8888")]
		Abgr32 = Rgba8888,
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_RGBX32")]
		[NativeName(NativeNameType.Value, "SDL_PIXELFORMAT_XBGR8888")]
		Rgbx32 = Xbgr8888,
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_XRGB32")]
		[NativeName(NativeNameType.Value, "SDL_PIXELFORMAT_BGRX8888")]
		Xrgb32 = Bgrx8888,
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_BGRX32")]
		[NativeName(NativeNameType.Value, "SDL_PIXELFORMAT_XRGB8888")]
		Bgrx32 = Xrgb8888,
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_XBGR32")]
		[NativeName(NativeNameType.Value, "SDL_PIXELFORMAT_RGBX8888")]
		Xbgr32 = Rgbx8888,
		/// <summary>
		/// Planar mode: Y + V + U  (3 planes) <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_YV12")]
		[NativeName(NativeNameType.Value, "842094169")]
		Yv12 = unchecked(842094169),

		/// <summary>
		/// Planar mode: Y + U + V  (3 planes) <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_IYUV")]
		[NativeName(NativeNameType.Value, "1448433993")]
		Iyuv = unchecked(1448433993),

		/// <summary>
		/// Packed mode: Y0+U0+Y1+V0 (1 plane) <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_YUY2")]
		[NativeName(NativeNameType.Value, "844715353")]
		Yuy2 = unchecked(844715353),

		/// <summary>
		/// Packed mode: U0+Y0+V0+Y1 (1 plane) <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_UYVY")]
		[NativeName(NativeNameType.Value, "1498831189")]
		Uyvy = unchecked(1498831189),

		/// <summary>
		/// Packed mode: Y0+V0+Y1+U0 (1 plane) <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_YVYU")]
		[NativeName(NativeNameType.Value, "1431918169")]
		Yvyu = unchecked(1431918169),

		/// <summary>
		/// Planar mode: Y + U/V interleaved  (2 planes) <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_NV12")]
		[NativeName(NativeNameType.Value, "842094158")]
		Nv12 = unchecked(842094158),

		/// <summary>
		/// Planar mode: Y + V/U interleaved  (2 planes) <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_NV21")]
		[NativeName(NativeNameType.Value, "825382478")]
		Nv21 = unchecked(825382478),

		/// <summary>
		/// Android video texture format <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_PIXELFORMAT_EXTERNAL_OES")]
		[NativeName(NativeNameType.Value, "542328143")]
		ExternalOes = unchecked(542328143),
	}
}
