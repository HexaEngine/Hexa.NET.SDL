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
	public readonly partial struct EGLImageKHR : IEquatable<EGLImageKHR>
	{
		public EGLImageKHR(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static EGLImageKHR Null => new EGLImageKHR(0);
		public static implicit operator EGLImageKHR(nint handle) => new EGLImageKHR(handle);
		public static bool operator ==(EGLImageKHR left, EGLImageKHR right) => left.Handle == right.Handle;
		public static bool operator !=(EGLImageKHR left, EGLImageKHR right) => left.Handle != right.Handle;
		public static bool operator ==(EGLImageKHR left, nint right) => left.Handle == right;
		public static bool operator !=(EGLImageKHR left, nint right) => left.Handle != right;
		public bool Equals(EGLImageKHR other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is EGLImageKHR handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("EGLImageKHR [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
