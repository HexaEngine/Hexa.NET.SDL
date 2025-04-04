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
	/// Specifies the timing that will be used to present swapchain textures to the<br/>
	/// OS.<br/>
	/// VSYNC mode will always be supported. IMMEDIATE and MAILBOX modes may not be<br/>
	/// supported on certain systems.<br/>
	/// It is recommended to query SDL_WindowSupportsGPUPresentMode after claiming<br/>
	/// the window if you wish to change the present mode to IMMEDIATE or MAILBOX.<br/>
	/// - VSYNC: Waits for vblank before presenting. No tearing is possible. If<br/>
	/// there is a pending image to present, the new image is enqueued for<br/>
	/// presentation. Disallows tearing at the cost of visual latency.<br/>
	/// - IMMEDIATE: Immediately presents. Lowest latency option, but tearing may<br/>
	/// occur.<br/>
	/// - MAILBOX: Waits for vblank before presenting. No tearing is possible. If<br/>
	/// there is a pending image to present, the pending image is replaced by the<br/>
	/// new image. Similar to VSYNC, but with reduced visual latency.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[Flags]
	public enum SDLGPUPresentMode : int
	{
		Vsync = unchecked(0),
		Immediate = unchecked(1),
		Mailbox = unchecked(2),
	}
}
