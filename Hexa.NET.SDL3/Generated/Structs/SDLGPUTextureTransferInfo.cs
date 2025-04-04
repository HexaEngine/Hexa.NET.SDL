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
	/// A structure specifying parameters related to transferring data to or from a<br/>
	/// texture.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLGPUTextureTransferInfo
	{
		/// <summary>
		/// The transfer buffer used in the transfer operation. <br/>
		/// </summary>
		public unsafe SDLGPUTransferBuffer* TransferBuffer;

		/// <summary>
		/// The starting byte of the image data in the transfer buffer. <br/>
		/// </summary>
		public uint Offset;

		/// <summary>
		/// The number of pixels from one row to the next. <br/>
		/// </summary>
		public uint PixelsPerRow;

		/// <summary>
		/// The number of rows from one layer/depth-slice to the next. <br/>
		/// </summary>
		public uint RowsPerLayer;


		public unsafe SDLGPUTextureTransferInfo(SDLGPUTransferBuffer* transferBuffer = default, uint offset = default, uint pixelsPerRow = default, uint rowsPerLayer = default)
		{
			TransferBuffer = transferBuffer;
			Offset = offset;
			PixelsPerRow = pixelsPerRow;
			RowsPerLayer = rowsPerLayer;
		}


	}

}
