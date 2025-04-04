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
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct EGLContext : IEquatable<EGLContext>
	{
		public EGLContext(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static EGLContext Null => new EGLContext(0);
		public static implicit operator EGLContext(nint handle) => new EGLContext(handle);
		public static bool operator ==(EGLContext left, EGLContext right) => left.Handle == right.Handle;
		public static bool operator !=(EGLContext left, EGLContext right) => left.Handle != right.Handle;
		public static bool operator ==(EGLContext left, nint right) => left.Handle == right;
		public static bool operator !=(EGLContext left, nint right) => left.Handle != right;
		public bool Equals(EGLContext other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is EGLContext handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("EGLContext [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
