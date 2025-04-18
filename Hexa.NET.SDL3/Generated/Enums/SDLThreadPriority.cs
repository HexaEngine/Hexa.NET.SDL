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
	/// The SDL thread priority.<br/>
	/// SDL will make system changes as necessary in order to apply the thread<br/>
	/// priority. Code which attempts to control thread state related to priority<br/>
	/// should be aware that calling SDL_SetCurrentThreadPriority may alter such<br/>
	/// state. SDL_HINT_THREAD_PRIORITY_POLICY can be used to control aspects of<br/>
	/// this behavior.<br/>
	/// <br/>
	/// </summary>
	[Flags]
	public enum SDLThreadPriority : int
	{
		Low = unchecked(0),
		Normal = unchecked(1),
		High = unchecked(2),
		TimeCritical = unchecked(3),
	}
}
