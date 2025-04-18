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
	/// The preferred date format of the current system locale.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[Flags]
	public enum SDLDateFormat : int
	{
		/// <summary>
		/// Year/Month/Day <br/>
		/// </summary>
		Yyyymmdd = unchecked(0),

		/// <summary>
		/// Day/Month/Year <br/>
		/// </summary>
		Ddmmyyyy = unchecked(1),

		/// <summary>
		/// Month/Day/Year <br/>
		/// </summary>
		Mmddyyyy = unchecked(2),
	}
}
