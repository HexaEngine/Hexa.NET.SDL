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
	/// The position of camera in relation to system device.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_CameraPosition")]
	[Flags]
	public enum SDLCameraPosition : int
	{
		[NativeName(NativeNameType.EnumItem, "SDL_CAMERA_POSITION_UNKNOWN")]
		[NativeName(NativeNameType.Value, "0")]
		Unknown = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "SDL_CAMERA_POSITION_FRONT_FACING")]
		[NativeName(NativeNameType.Value, "1")]
		FrontFacing = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "SDL_CAMERA_POSITION_BACK_FACING")]
		[NativeName(NativeNameType.Value, "2")]
		BackFacing = unchecked(2),
	}
}
