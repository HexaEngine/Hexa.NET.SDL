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
using System.Runtime.InteropServices;
using HexaGen.Runtime;

namespace Hexa.NET.SDL2
{
	/// <summary>
	/// SDL_iconv_* are now always real symbols/types, not macros or inlined. <br/>
	/// </summary>
	[NativeName(NativeNameType.Typedef, "SDL_iconv_t")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct SDLIconv : IEquatable<SDLIconv>
	{
		public SDLIconv(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static SDLIconv Null => new SDLIconv(0);
		public static implicit operator SDLIconv(nint handle) => new SDLIconv(handle);
		public static bool operator ==(SDLIconv left, SDLIconv right) => left.Handle == right.Handle;
		public static bool operator !=(SDLIconv left, SDLIconv right) => left.Handle != right.Handle;
		public static bool operator ==(SDLIconv left, nint right) => left.Handle == right;
		public static bool operator !=(SDLIconv left, nint right) => left.Handle != right;
		public bool Equals(SDLIconv other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is SDLIconv handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("SDLIconv [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
