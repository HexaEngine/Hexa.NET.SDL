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

namespace Hexa.NET.SDL2
{
	/// <summary>
	/// Event subtype for display events<br/>
	/// </summary>
	[Flags]
	public enum SDLDisplayEventID : int
	{
		/// <summary>
		/// Never used <br/>
		/// </summary>
		None = unchecked(0),

		/// <summary>
		/// Display orientation has changed to data1 <br/>
		/// </summary>
		Orientation = unchecked(1),

		/// <summary>
		/// Display has been added to the system <br/>
		/// </summary>
		Connected = unchecked(2),

		/// <summary>
		/// Display has been removed from the system <br/>
		/// </summary>
		Disconnected = unchecked(3),

		/// <summary>
		/// Display has changed position <br/>
		/// </summary>
		Moved = unchecked(4),
	}
}
