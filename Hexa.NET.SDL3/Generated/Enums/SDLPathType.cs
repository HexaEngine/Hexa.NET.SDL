// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;

namespace Hexa.NET.SDL3
{
	/// <summary>
	/// Types of filesystem entries.<br/>
	/// Note that there may be other sorts of items on a filesystem: devices,<br/>
	/// symlinks, named pipes, etc. They are currently reported as<br/>
	/// SDL_PATHTYPE_OTHER.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[Flags]
	public enum SDLPathType : int
	{
		/// <summary>
		/// path does not exist <br/>
		/// </summary>
		None = unchecked(0),

		/// <summary>
		/// a normal file <br/>
		/// </summary>
		File = unchecked(1),

		/// <summary>
		/// a directory <br/>
		/// </summary>
		Directory = unchecked(2),

		/// <summary>
		/// something completely different like a device node (not a symlink, those are always followed) <br/>
		/// </summary>
		Other = unchecked(3),
	}
}
