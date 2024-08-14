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
	[NativeName(NativeNameType.Typedef, "GLeglImageOES")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct GLeglImageOES : IEquatable<GLeglImageOES>
	{
		public GLeglImageOES(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static GLeglImageOES Null => new GLeglImageOES(0);
		public static implicit operator GLeglImageOES(nint handle) => new GLeglImageOES(handle);
		public static bool operator ==(GLeglImageOES left, GLeglImageOES right) => left.Handle == right.Handle;
		public static bool operator !=(GLeglImageOES left, GLeglImageOES right) => left.Handle != right.Handle;
		public static bool operator ==(GLeglImageOES left, nint right) => left.Handle == right;
		public static bool operator !=(GLeglImageOES left, nint right) => left.Handle != right;
		public bool Equals(GLeglImageOES other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is GLeglImageOES handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("GLeglImageOES [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
