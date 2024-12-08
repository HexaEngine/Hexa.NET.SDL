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
	/// Colorspace transfer characteristics.<br/>
	/// These are as described by https://www.itu.int/rec/T-REC-H.273-201612-S/en<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_TransferCharacteristics")]
	[Flags]
	public enum SDLTransferCharacteristics : int
	{
		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_UNKNOWN")]
		[NativeName(NativeNameType.Value, "0")]
		Unknown = unchecked(0),
		/// <summary>
		/// Rec. ITU-R BT.709-6 / ITU-R BT1361 <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_BT709")]
		[NativeName(NativeNameType.Value, "1")]
		Bt709 = unchecked(1),

		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_UNSPECIFIED")]
		[NativeName(NativeNameType.Value, "2")]
		Unspecified = unchecked(2),
		/// <summary>
		/// ITU-R BT.470-6 System M / ITU-R BT1700 625 PAL <br/>
		/// &<br/>
		/// SECAM <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_GAMMA22")]
		[NativeName(NativeNameType.Value, "4")]
		Gamma22 = unchecked(4),

		/// <summary>
		/// ITU-R BT.470-6 System B, G <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_GAMMA28")]
		[NativeName(NativeNameType.Value, "5")]
		Gamma28 = unchecked(5),

		/// <summary>
		/// SMPTE ST 170M / ITU-R BT.601-7 525 or 625 <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_BT601")]
		[NativeName(NativeNameType.Value, "6")]
		Bt601 = unchecked(6),

		/// <summary>
		/// SMPTE ST 240M <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_SMPTE240")]
		[NativeName(NativeNameType.Value, "7")]
		Smpte240 = unchecked(7),

		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_LINEAR")]
		[NativeName(NativeNameType.Value, "8")]
		Linear = unchecked(8),
		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_LOG100")]
		[NativeName(NativeNameType.Value, "9")]
		Log100 = unchecked(9),
		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_LOG100_SQRT10")]
		[NativeName(NativeNameType.Value, "10")]
		Log100Sqrt10 = unchecked(10),
		/// <summary>
		/// IEC 61966-2-4 <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_IEC61966")]
		[NativeName(NativeNameType.Value, "11")]
		Iec61966 = unchecked(11),

		/// <summary>
		/// ITU-R BT1361 Extended Colour Gamut <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_BT1361")]
		[NativeName(NativeNameType.Value, "12")]
		Bt1361 = unchecked(12),

		/// <summary>
		/// IEC 61966-2-1 (sRGB or sYCC) <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_SRGB")]
		[NativeName(NativeNameType.Value, "13")]
		Srgb = unchecked(13),

		/// <summary>
		/// ITU-R BT2020 for 10-bit system <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_BT2020_10BIT")]
		[NativeName(NativeNameType.Value, "14")]
		Bt202010 = unchecked(14),

		/// <summary>
		/// ITU-R BT2020 for 12-bit system <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_BT2020_12BIT")]
		[NativeName(NativeNameType.Value, "15")]
		Bt202012 = unchecked(15),

		/// <summary>
		/// SMPTE ST 2084 for 10-, 12-, 14- and 16-bit systems <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_PQ")]
		[NativeName(NativeNameType.Value, "16")]
		Pq = unchecked(16),

		/// <summary>
		/// SMPTE ST 428-1 <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_SMPTE428")]
		[NativeName(NativeNameType.Value, "17")]
		Smpte428 = unchecked(17),

		/// <summary>
		/// ARIB STD-B67, known as "hybrid log-gamma" (HLG) <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_HLG")]
		[NativeName(NativeNameType.Value, "18")]
		Hlg = unchecked(18),

		[NativeName(NativeNameType.EnumItem, "SDL_TRANSFER_CHARACTERISTICS_CUSTOM")]
		[NativeName(NativeNameType.Value, "31")]
		Custom = unchecked(31),
	}
}