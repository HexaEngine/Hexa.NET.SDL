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
	[NativeName(NativeNameType.Typedef, "EGLObjectKHR")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct EGLObjectKHR : IEquatable<EGLObjectKHR>
	{
		public EGLObjectKHR(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static EGLObjectKHR Null => new EGLObjectKHR(0);
		public static implicit operator EGLObjectKHR(nint handle) => new EGLObjectKHR(handle);
		public static bool operator ==(EGLObjectKHR left, EGLObjectKHR right) => left.Handle == right.Handle;
		public static bool operator !=(EGLObjectKHR left, EGLObjectKHR right) => left.Handle != right.Handle;
		public static bool operator ==(EGLObjectKHR left, nint right) => left.Handle == right;
		public static bool operator !=(EGLObjectKHR left, nint right) => left.Handle != right;
		public bool Equals(EGLObjectKHR other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is EGLObjectKHR handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("EGLObjectKHR [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
