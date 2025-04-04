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
	/// The type of the OS-provided default folder for a specific purpose.<br/>
	/// Note that the Trash folder isn't included here, because trashing files<br/>
	/// usually involves extra OS-specific functionality to remember the file's<br/>
	/// original location.<br/>
	/// The folders supported per platform are:<br/>
	/// |             | Windows | macOS/iOS | tvOS | Unix (XDG) | Haiku | Emscripten |<br/>
	/// | ----------- | ------- | --------- | ---- | ---------- | ----- | ---------- |<br/>
	/// | HOME        | X       | X         |      | X          | X     | X          |<br/>
	/// | DESKTOP     | X       | X         |      | X          | X     |            |<br/>
	/// | DOCUMENTS   | X       | X         |      | X          |       |            |<br/>
	/// | DOWNLOADS   | Vista+  | X         |      | X          |       |            |<br/>
	/// | MUSIC       | X       | X         |      | X          |       |            |<br/>
	/// | PICTURES    | X       | X         |      | X          |       |            |<br/>
	/// | PUBLICSHARE |         | X         |      | X          |       |            |<br/>
	/// | SAVEDGAMES  | Vista+  |           |      |            |       |            |<br/>
	/// | SCREENSHOTS | Vista+  |           |      |            |       |            |<br/>
	/// | TEMPLATES   | X       | X         |      | X          |       |            |<br/>
	/// | VIDEOS      | X       | X*        |      | X          |       |            |<br/>
	/// Note that on macOS/iOS, the Videos folder is called "Movies".<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[Flags]
	public enum SDLFolder : int
	{
		/// <summary>
		/// The folder which contains all of the current user's data, preferences, and documents. It usually contains most of the other folders. If a requested folder does not exist, the home folder can be considered a safe fallback to store a user's documents. <br/>
		/// </summary>
		Home = unchecked(0),

		/// <summary>
		/// The folder of files that are displayed on the desktop. Note that the existence of a desktop folder does not guarantee that the system does show icons on its desktop; certain GNU/Linux distros with a graphical environment may not have desktop icons. <br/>
		/// </summary>
		Desktop = unchecked(1),

		/// <summary>
		/// User document files, possibly application-specific. This is a good place to save a user's projects. <br/>
		/// </summary>
		Documents = unchecked(2),

		/// <summary>
		/// Standard folder for user files downloaded from the internet. <br/>
		/// </summary>
		Downloads = unchecked(3),

		/// <summary>
		/// Music files that can be played using a standard music player (mp3, ogg...). <br/>
		/// </summary>
		Music = unchecked(4),

		/// <summary>
		/// Image files that can be displayed using a standard viewer (png, jpg...). <br/>
		/// </summary>
		Pictures = unchecked(5),

		/// <summary>
		/// Files that are meant to be shared with other users on the same computer. <br/>
		/// </summary>
		Publicshare = unchecked(6),

		/// <summary>
		/// Save files for games. <br/>
		/// </summary>
		Savedgames = unchecked(7),

		/// <summary>
		/// Application screenshots. <br/>
		/// </summary>
		Screenshots = unchecked(8),

		/// <summary>
		/// Template files to be used when the user requests the desktop environment to create a new file in a certain folder, such as "New Text File.txt".  Any file in the Templates folder can be used as a starting point for a new file. <br/>
		/// </summary>
		Templates = unchecked(9),

		/// <summary>
		/// Video files that can be played using a standard video player (mp4, webm...). <br/>
		/// </summary>
		Videos = unchecked(10),

		/// <summary>
		/// Total number of types in this enum, not a folder type by itself. <br/>
		/// </summary>
		Count = unchecked(11),
	}
}
