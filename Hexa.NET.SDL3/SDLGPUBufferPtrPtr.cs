namespace Hexa.NET.SDL3
{
    using HexaGen.Runtime;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [NativeName(NativeNameType.Typedef, "SDL_GPUBuffer")]
#if NET5_0_OR_GREATER
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
#endif
    public unsafe struct SDLGPUBufferPtrPtr : IEquatable<SDLGPUBufferPtrPtr>
    {
        public SDLGPUBufferPtrPtr(SDLGPUBuffer** handle)
        {
            Handle = handle;
        }

        public SDLGPUBuffer** Handle;

        public bool IsNull => Handle == null;

        public static SDLGPUBufferPtrPtr Null => new SDLGPUBufferPtrPtr(null);

        public SDLGPUBuffer* this[int index] { get => Handle[index]; set => Handle[index] = value; }

        public static implicit operator SDLGPUBufferPtrPtr(SDLGPUBuffer** handle) => new SDLGPUBufferPtrPtr(handle);

        public static implicit operator SDLGPUBuffer**(SDLGPUBufferPtrPtr handle) => handle.Handle;

        public static bool operator ==(SDLGPUBufferPtrPtr left, SDLGPUBufferPtrPtr right) => left.Handle == right.Handle;

        public static bool operator !=(SDLGPUBufferPtrPtr left, SDLGPUBufferPtrPtr right) => left.Handle != right.Handle;

        public static bool operator ==(SDLGPUBufferPtrPtr left, SDLGPUBuffer** right) => left.Handle == right;

        public static bool operator !=(SDLGPUBufferPtrPtr left, SDLGPUBuffer** right) => left.Handle != right;

        public bool Equals(SDLGPUBufferPtrPtr other) => Handle == other.Handle;

        /// <inheritdoc/>
        public override bool Equals(object obj) => obj is SDLGPUBufferPtrPtr handle && Equals(handle);

        /// <inheritdoc/>
        public override int GetHashCode() => ((nuint)Handle).GetHashCode();

#if NET5_0_OR_GREATER
        private string DebuggerDisplay => string.Format("SDLGPUBufferPtrPtr [0x{0}]", ((nuint)Handle).ToString("X"));
#endif
    }
}