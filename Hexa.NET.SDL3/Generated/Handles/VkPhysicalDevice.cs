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
	[NativeName(NativeNameType.Typedef, "VkPhysicalDevice")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct VkPhysicalDevice : IEquatable<VkPhysicalDevice>
	{
		public VkPhysicalDevice(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static VkPhysicalDevice Null => new VkPhysicalDevice(0);
		public static implicit operator VkPhysicalDevice(nint handle) => new VkPhysicalDevice(handle);
		public static bool operator ==(VkPhysicalDevice left, VkPhysicalDevice right) => left.Handle == right.Handle;
		public static bool operator !=(VkPhysicalDevice left, VkPhysicalDevice right) => left.Handle != right.Handle;
		public static bool operator ==(VkPhysicalDevice left, nint right) => left.Handle == right;
		public static bool operator !=(VkPhysicalDevice left, nint right) => left.Handle != right;
		public bool Equals(VkPhysicalDevice other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is VkPhysicalDevice handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("VkPhysicalDevice [0x{0}]", Handle.ToString("X"));
		#endif
	}
}