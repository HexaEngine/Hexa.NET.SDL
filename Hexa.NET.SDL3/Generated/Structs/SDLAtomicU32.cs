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
	/// A type representing an atomic unsigned 32-bit value.<br/>
	/// This can be used to manage a value that is synchronized across multiple<br/>
	/// CPUs without a race condition; when an app sets a value with<br/>
	/// SDL_SetAtomicU32 all other threads, regardless of the CPU it is running on,<br/>
	/// will see that value when retrieved with SDL_GetAtomicU32, regardless of CPU<br/>
	/// caches, etc.<br/>
	/// This is also useful for atomic compare-and-swap operations: a thread can<br/>
	/// change the value as long as its current value matches expectations. When<br/>
	/// done in a loop, one can guarantee data consistency across threads without a<br/>
	/// lock (but the usual warnings apply: if you don't know what you're doing, or<br/>
	/// you don't do it carefully, you can confidently cause any number of<br/>
	/// disasters with this, so in most cases, you _should_ use a mutex instead of<br/>
	/// this!).<br/>
	/// This is a struct so people don't accidentally use numeric operations on it<br/>
	/// directly. You have to use SDL atomic functions.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_AtomicU32")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLAtomicU32
	{
		[NativeName(NativeNameType.Field, "value")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Value;

		public unsafe SDLAtomicU32(uint value = default)
		{
			Value = value;
		}


	}

}