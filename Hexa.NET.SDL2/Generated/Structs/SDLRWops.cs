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

namespace Hexa.NET.SDL2
{
	/// <summary>
	/// This is the read/write operation structure -- very basic.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLRWops
	{
		[StructLayout(LayoutKind.Explicit)]
		public partial struct HiddenUnion
		{
			[StructLayout(LayoutKind.Sequential)]
			public partial struct WindowsioUnion
			{
				[StructLayout(LayoutKind.Sequential)]
				public partial struct BufferUnion
				{
					public unsafe void* Data;
					public nuint Size;
					public nuint Left;

					public unsafe BufferUnion(void* data = default, nuint size = default, nuint left = default)
					{
						Data = data;
						Size = size;
						Left = left;
					}


				}

				public SDLBool Append;
				public unsafe void* H;
				public BufferUnion Buffer;

				public unsafe WindowsioUnion(SDLBool append = default, void* h = default, BufferUnion buffer = default)
				{
					Append = append;
					H = h;
					Buffer = buffer;
				}


			}

			[StructLayout(LayoutKind.Sequential)]
			public partial struct MemUnion
			{
				public unsafe byte* Base;
				public unsafe byte* Here;
				public unsafe byte* Stop;

				public unsafe MemUnion(byte* baseValue = default, byte* here = default, byte* stop = default)
				{
					Base = baseValue;
					Here = here;
					Stop = stop;
				}


			}

			[StructLayout(LayoutKind.Sequential)]
			public partial struct UnknownUnion
			{
				public unsafe void* Data1;
				public unsafe void* Data2;

				public unsafe UnknownUnion(void* data1 = default, void* data2 = default)
				{
					Data1 = data1;
					Data2 = data2;
				}


			}

			[FieldOffset(0)]
			public WindowsioUnion Windowsio;
			[FieldOffset(0)]
			public MemUnion Mem;
			[FieldOffset(0)]
			public UnknownUnion Unknown;

			public unsafe HiddenUnion(WindowsioUnion windowsio = default, MemUnion mem = default, UnknownUnion unknown = default)
			{
				Windowsio = windowsio;
				Mem = mem;
				Unknown = unknown;
			}


		}

		/// <summary>
		/// Return the size of the file in this rwops, or -1 if unknown<br/>
		/// </summary>
		public unsafe void* Size;

		/// <summary>
		/// Seek to `offset` relative to `whence`, one of stdio's whence values:<br/>
		/// RW_SEEK_SET, RW_SEEK_CUR, RW_SEEK_END<br/>
		/// <br/>
		/// </summary>
		public unsafe void* Seek;

		/// <summary>
		/// Read up to `maxnum` objects each of size `size` from the data<br/>
		/// stream to the area pointed at by `ptr`.<br/>
		/// <br/>
		/// </summary>
		public unsafe void* Read;

		/// <summary>
		/// Write exactly `num` objects each of size `size` from the area<br/>
		/// pointed at by `ptr` to data stream.<br/>
		/// <br/>
		/// </summary>
		public unsafe void* Write;

		/// <summary>
		/// Close and free an allocated SDL_RWops structure.<br/>
		/// <br/>
		/// </summary>
		public unsafe void* Close;

		public uint Type;
		public HiddenUnion Union;

		public unsafe SDLRWops(delegate*<SDLRWops*, long> size = default, delegate*<SDLRWops*, long, int, long> seek = default, delegate*<SDLRWops*, void*, nuint, nuint, nuint> read = default, delegate*<SDLRWops*, void*, nuint, nuint, nuint> write = default, delegate*<SDLRWops*, int> close = default, uint type = default, HiddenUnion union = default)
		{
			Size = (delegate*<SDLRWops*, long>*)size;
			Seek = (delegate*<SDLRWops*, long, int, long>*)seek;
			Read = (delegate*<SDLRWops*, void*, nuint, nuint, nuint>*)read;
			Write = (delegate*<SDLRWops*, void*, nuint, nuint, nuint>*)write;
			Close = (delegate*<SDLRWops*, int>*)close;
			Type = type;
			Union = union;
		}


	}

}
