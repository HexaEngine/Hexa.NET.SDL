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
	/// The types of events that can be delivered.<br/>
	/// </summary>
	[Flags]
	public enum SDLEventType : int
	{
		/// <summary>
		/// Unused (do not remove) <br/>
		/// </summary>
		Firstevent = unchecked(0),

		/// <summary>
		/// User-requested quit <br/>
		/// </summary>
		Quit = unchecked(256),

		/// <summary>
		/// The application is being terminated by the OS<br/>
		/// Called on iOS in applicationWillTerminate()<br/>
		/// Called on Android in onDestroy()<br/>
		/// </summary>
		AppTerminating = unchecked(257),

		/// <summary>
		/// The application is low on memory, free memory if possible.<br/>
		/// Called on iOS in applicationDidReceiveMemoryWarning()<br/>
		/// Called on Android in onLowMemory()<br/>
		/// </summary>
		AppLowmemory = unchecked(258),

		/// <summary>
		/// The application is about to enter the background<br/>
		/// Called on iOS in applicationWillResignActive()<br/>
		/// Called on Android in onPause()<br/>
		/// </summary>
		AppWillenterbackground = unchecked(259),

		/// <summary>
		/// The application did enter the background and may not get CPU for some time<br/>
		/// Called on iOS in applicationDidEnterBackground()<br/>
		/// Called on Android in onPause()<br/>
		/// </summary>
		AppDidenterbackground = unchecked(260),

		/// <summary>
		/// The application is about to enter the foreground<br/>
		/// Called on iOS in applicationWillEnterForeground()<br/>
		/// Called on Android in onResume()<br/>
		/// </summary>
		AppWillenterforeground = unchecked(261),

		/// <summary>
		/// The application is now interactive<br/>
		/// Called on iOS in applicationDidBecomeActive()<br/>
		/// Called on Android in onResume()<br/>
		/// </summary>
		AppDidenterforeground = unchecked(262),

		/// <summary>
		/// The user's locale preferences have changed. <br/>
		/// </summary>
		Localechanged = unchecked(263),

		/// <summary>
		/// Display state change <br/>
		/// </summary>
		Displayevent = unchecked(336),

		/// <summary>
		/// Window state change <br/>
		/// </summary>
		Windowevent = unchecked(512),

		/// <summary>
		/// System specific event <br/>
		/// </summary>
		Syswmevent = unchecked(513),

		/// <summary>
		/// Key pressed <br/>
		/// </summary>
		Keydown = unchecked(768),

		/// <summary>
		/// Key released <br/>
		/// </summary>
		Keyup = unchecked(769),

		/// <summary>
		/// Keyboard text editing (composition) <br/>
		/// </summary>
		Textediting = unchecked(770),

		/// <summary>
		/// Keyboard text input <br/>
		/// </summary>
		Textinput = unchecked(771),

		/// <summary>
		/// Keymap changed due to a system event such as an<br/>
		/// input language or keyboard layout change.<br/>
		/// </summary>
		Keymapchanged = unchecked(772),

		/// <summary>
		/// Extended keyboard text editing (composition) <br/>
		/// </summary>
		TexteditingExt = unchecked(773),

		/// <summary>
		/// Mouse moved <br/>
		/// </summary>
		Mousemotion = unchecked(1024),

		/// <summary>
		/// Mouse button pressed <br/>
		/// </summary>
		Mousebuttondown = unchecked(1025),

		/// <summary>
		/// Mouse button released <br/>
		/// </summary>
		Mousebuttonup = unchecked(1026),

		/// <summary>
		/// Mouse wheel motion <br/>
		/// </summary>
		Mousewheel = unchecked(1027),

		/// <summary>
		/// Joystick axis motion <br/>
		/// </summary>
		Joyaxismotion = unchecked(1536),

		/// <summary>
		/// Joystick trackball motion <br/>
		/// </summary>
		Joyballmotion = unchecked(1537),

		/// <summary>
		/// Joystick hat position change <br/>
		/// </summary>
		Joyhatmotion = unchecked(1538),

		/// <summary>
		/// Joystick button pressed <br/>
		/// </summary>
		Joybuttondown = unchecked(1539),

		/// <summary>
		/// Joystick button released <br/>
		/// </summary>
		Joybuttonup = unchecked(1540),

		/// <summary>
		/// A new joystick has been inserted into the system <br/>
		/// </summary>
		Joydeviceadded = unchecked(1541),

		/// <summary>
		/// An opened joystick has been removed <br/>
		/// </summary>
		Joydeviceremoved = unchecked(1542),

		/// <summary>
		/// Joystick battery level change <br/>
		/// </summary>
		Joybatteryupdated = unchecked(1543),

		/// <summary>
		/// Game controller axis motion <br/>
		/// </summary>
		Controlleraxismotion = unchecked(1616),

		/// <summary>
		/// Game controller button pressed <br/>
		/// </summary>
		Controllerbuttondown = unchecked(1617),

		/// <summary>
		/// Game controller button released <br/>
		/// </summary>
		Controllerbuttonup = unchecked(1618),

		/// <summary>
		/// A new Game controller has been inserted into the system <br/>
		/// </summary>
		Controllerdeviceadded = unchecked(1619),

		/// <summary>
		/// An opened Game controller has been removed <br/>
		/// </summary>
		Controllerdeviceremoved = unchecked(1620),

		/// <summary>
		/// The controller mapping was updated <br/>
		/// </summary>
		Controllerdeviceremapped = unchecked(1621),

		/// <summary>
		/// Game controller touchpad was touched <br/>
		/// </summary>
		Controllertouchpaddown = unchecked(1622),

		/// <summary>
		/// Game controller touchpad finger was moved <br/>
		/// </summary>
		Controllertouchpadmotion = unchecked(1623),

		/// <summary>
		/// Game controller touchpad finger was lifted <br/>
		/// </summary>
		Controllertouchpadup = unchecked(1624),

		/// <summary>
		/// Game controller sensor was updated <br/>
		/// </summary>
		Controllersensorupdate = unchecked(1625),

		ControllerupdatecompleteReservedForSdl3 = unchecked(1626),
		/// <summary>
		/// Game controller Steam handle has changed <br/>
		/// </summary>
		Controllersteamhandleupdated = unchecked(1627),

		/// <summary>
		/// Touch events <br/>
		/// </summary>
		Fingerdown = unchecked(1792),

		/// <summary>
		/// Touch events <br/>
		/// </summary>
		Fingerup = unchecked(1793),

		/// <summary>
		/// Touch events <br/>
		/// </summary>
		Fingermotion = unchecked(1794),

		/// <summary>
		/// Gesture events <br/>
		/// </summary>
		Dollargesture = unchecked(2048),

		/// <summary>
		/// Gesture events <br/>
		/// </summary>
		Dollarrecord = unchecked(2049),

		/// <summary>
		/// Gesture events <br/>
		/// </summary>
		Multigesture = unchecked(2050),

		/// <summary>
		/// The clipboard or primary selection changed <br/>
		/// </summary>
		Clipboardupdate = unchecked(2304),

		/// <summary>
		/// The system requests a file open <br/>
		/// </summary>
		Dropfile = unchecked(4096),

		/// <summary>
		/// text/plain drag-and-drop event <br/>
		/// </summary>
		Droptext = unchecked(4097),

		/// <summary>
		/// A new set of drops is beginning (NULL filename) <br/>
		/// </summary>
		Dropbegin = unchecked(4098),

		/// <summary>
		/// Current set of drops is now complete (NULL filename) <br/>
		/// </summary>
		Dropcomplete = unchecked(4099),

		/// <summary>
		/// A new audio device is available <br/>
		/// </summary>
		Audiodeviceadded = unchecked(4352),

		/// <summary>
		/// An audio device has been removed. <br/>
		/// </summary>
		Audiodeviceremoved = unchecked(4353),

		/// <summary>
		/// A sensor was updated <br/>
		/// </summary>
		Sensorupdate = unchecked(4608),

		/// <summary>
		/// The render targets have been reset and their contents need to be updated <br/>
		/// </summary>
		RenderTargetsReset = unchecked(8192),

		/// <summary>
		/// The device has been reset and all textures need to be recreated <br/>
		/// </summary>
		RenderDeviceReset = unchecked(8193),

		/// <summary>
		/// Signals the end of an event poll cycle <br/>
		/// </summary>
		Pollsentinel = unchecked(32512),

		/// <summary>
		/// Events SDL_USEREVENT through SDL_LASTEVENT are for your use,<br/>
		/// and should be allocated with SDL_RegisterEvents()<br/>
		/// </summary>
		Userevent = unchecked(32768),

		/// <summary>
		/// This last event is only for bounding internal arrays<br/>
		/// </summary>
		Lastevent = unchecked(65535),
	}
}
