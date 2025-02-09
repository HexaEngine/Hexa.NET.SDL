// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;

namespace Hexa.NET.SDL3
{
	/// <summary>
	/// Information about a path on the filesystem.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_PathInfo")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLPathInfo
	{
		/// <summary>
		/// the path type <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "type")]
		[NativeName(NativeNameType.Type, "SDL_PathType")]
		public SDLPathType Type;

		/// <summary>
		/// the file size in bytes <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "size")]
		[NativeName(NativeNameType.Type, "Uint64")]
		public ulong Size;

		/// <summary>
		/// the time when the path was created <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "create_time")]
		[NativeName(NativeNameType.Type, "SDL_Time")]
		public long CreateTime;

		/// <summary>
		/// the last time the path was modified <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "modify_time")]
		[NativeName(NativeNameType.Type, "SDL_Time")]
		public long ModifyTime;

		/// <summary>
		/// the last time the path was read <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "access_time")]
		[NativeName(NativeNameType.Type, "SDL_Time")]
		public long AccessTime;


		public unsafe SDLPathInfo(SDLPathType type = default, ulong size = default, long createTime = default, long modifyTime = default, long accessTime = default)
		{
			Type = type;
			Size = size;
			CreateTime = createTime;
			ModifyTime = modifyTime;
			AccessTime = accessTime;
		}


	}

}
