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
	/// A structure specifying the parameters of a transfer buffer.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SDL_GPUTransferBufferCreateInfo")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLGPUTransferBufferCreateInfo
	{
		/// <summary>
		/// How the transfer buffer is intended to be used by the client. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "usage")]
		[NativeName(NativeNameType.Type, "SDL_GPUTransferBufferUsage")]
		public SDLGPUTransferBufferUsage Usage;

		/// <summary>
		/// The size in bytes of the transfer buffer. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "size")]
		[NativeName(NativeNameType.Type, "Uint32")]
		public uint Size;

		/// <summary>
		/// A properties ID for extensions. Should be 0 if no extensions are needed. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "props")]
		[NativeName(NativeNameType.Type, "SDL_PropertiesID")]
		public uint Props;


		public unsafe SDLGPUTransferBufferCreateInfo(SDLGPUTransferBufferUsage usage = default, uint size = default, uint props = default)
		{
			Usage = usage;
			Size = size;
			Props = props;
		}


	}

}