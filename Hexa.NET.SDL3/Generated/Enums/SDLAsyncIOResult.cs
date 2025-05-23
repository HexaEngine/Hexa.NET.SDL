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
	[Flags]
	public enum SDLAsyncIOResult : int
	{
		/// <summary>
		/// request was completed without error <br/>
		/// </summary>
		Complete = unchecked(0),

		/// <summary>
		/// request failed for some reason; check SDL_GetError()! <br/>
		/// </summary>
		Failure = unchecked(1),

		/// <summary>
		/// request was canceled before completing. <br/>
		/// </summary>
		Canceled = unchecked(2),
	}
}
