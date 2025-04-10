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
	/// The function pointers that drive an SDL_IOStream.<br/>
	/// Applications can provide this struct to SDL_OpenIO() to create their own<br/>
	/// implementation of SDL_IOStream. This is not necessarily required, as SDL<br/>
	/// already offers several common types of I/O streams, via functions like<br/>
	/// SDL_IOFromFile() and SDL_IOFromMem().<br/>
	/// This structure should be initialized using SDL_INIT_INTERFACE()<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLIOStreamInterface
	{
		/// <summary>
		/// The version of this interface <br/>
		/// </summary>
		public uint Version;

		/// <summary>
		/// Return the number of bytes in this SDL_IOStream<br/>
		/// <br/>
		/// </summary>
		public unsafe void* Size;

		/// <summary>
		/// Seek to `offset` relative to `whence`, one of stdio's whence values:<br/>
		/// SDL_IO_SEEK_SET, SDL_IO_SEEK_CUR, SDL_IO_SEEK_END<br/>
		/// <br/>
		/// </summary>
		public unsafe void* Seek;

		/// <summary>
		/// Read up to `size` bytes from the data stream to the area pointed<br/>
		/// at by `ptr`.<br/>
		/// On an incomplete read, you should set `*status` to a value from the<br/>
		/// SDL_IOStatus enum. You do not have to explicitly set this on<br/>
		/// a complete, successful read.<br/>
		/// <br/>
		/// </summary>
		public unsafe void* Read;

		/// <summary>
		/// Write exactly `size` bytes from the area pointed at by `ptr`<br/>
		/// to data stream.<br/>
		/// On an incomplete write, you should set `*status` to a value from the<br/>
		/// SDL_IOStatus enum. You do not have to explicitly set this on<br/>
		/// a complete, successful write.<br/>
		/// <br/>
		/// </summary>
		public unsafe void* Write;

		/// <summary>
		/// If the stream is buffering, make sure the data is written out.<br/>
		/// On failure, you should set `*status` to a value from the<br/>
		/// SDL_IOStatus enum. You do not have to explicitly set this on<br/>
		/// a successful flush.<br/>
		/// <br/>
		/// </summary>
		public unsafe void* Flush;

		/// <summary>
		/// Close and free any allocated resources.<br/>
		/// This does not guarantee file writes will sync to physical media; they<br/>
		/// can be in the system's file cache, waiting to go to disk.<br/>
		/// The SDL_IOStream is still destroyed even if this fails, so clean up anything<br/>
		/// even if flushing buffers, etc, returns an error.<br/>
		/// <br/>
		/// </summary>
		public unsafe void* Close;


		public unsafe SDLIOStreamInterface(uint version = default, delegate*<void*, long> size = default, delegate*<void*, long, SDLIOWhence, long> seek = default, delegate*<void*, void*, nuint, SDLIOStatus*, nuint> read = default, delegate*<void*, void*, nuint, SDLIOStatus*, nuint> write = default, delegate*<void*, SDLIOStatus*, bool> flush = default, delegate*<void*, bool> close = default)
		{
			Version = version;
			Size = (delegate*<void*, long>*)size;
			Seek = (delegate*<void*, long, SDLIOWhence, long>*)seek;
			Read = (delegate*<void*, void*, nuint, SDLIOStatus*, nuint>*)read;
			Write = (delegate*<void*, void*, nuint, SDLIOStatus*, nuint>*)write;
			Flush = (delegate*<void*, SDLIOStatus*, bool>*)flush;
			Close = (delegate*<void*, bool>*)close;
		}


	}

}
