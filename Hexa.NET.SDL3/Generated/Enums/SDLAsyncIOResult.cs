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
	/// Possible outcomes of an asynchronous I/O task.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_AsyncIOResult")]
	[Flags]
	public enum SDLAsyncIOResult : int
	{
		/// <summary>
		/// request was completed without error <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_ASYNCIO_COMPLETE")]
		[NativeName(NativeNameType.Value, "0")]
		Complete = unchecked(0),

		/// <summary>
		/// request failed for some reason; check SDL_GetError()! <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_ASYNCIO_FAILURE")]
		[NativeName(NativeNameType.Value, "1")]
		Failure = unchecked(1),

		/// <summary>
		/// request was canceled before completing. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_ASYNCIO_CANCELED")]
		[NativeName(NativeNameType.Value, "2")]
		Canceled = unchecked(2),
	}
}
