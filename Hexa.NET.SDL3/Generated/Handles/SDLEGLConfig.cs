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

namespace Hexa.NET.SDL3
{
	/// <summary>
	/// Opaque type for an EGL config.<br/>
	/// <br/>
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct SDLEGLConfig : IEquatable<SDLEGLConfig>
	{
		public SDLEGLConfig(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static SDLEGLConfig Null => new SDLEGLConfig(0);
		public static implicit operator SDLEGLConfig(nint handle) => new SDLEGLConfig(handle);
		public static bool operator ==(SDLEGLConfig left, SDLEGLConfig right) => left.Handle == right.Handle;
		public static bool operator !=(SDLEGLConfig left, SDLEGLConfig right) => left.Handle != right.Handle;
		public static bool operator ==(SDLEGLConfig left, nint right) => left.Handle == right;
		public static bool operator !=(SDLEGLConfig left, nint right) => left.Handle != right;
		public bool Equals(SDLEGLConfig other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is SDLEGLConfig handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("SDLEGLConfig [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
