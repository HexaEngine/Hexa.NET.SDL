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
	/// Text input type.<br/>
	/// These are the valid values for SDL_PROP_TEXTINPUT_TYPE_NUMBER. Not every<br/>
	/// value is valid on every platform, but where a value isn't supported, a<br/>
	/// reasonable fallback will be used.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SDL_TextInputType")]
	[Flags]
	public enum SDLTextInputType : int
	{
		/// <summary>
		/// The input is text <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TEXTINPUT_TYPE_TEXT")]
		[NativeName(NativeNameType.Value, "0")]
		Text = unchecked(0),

		/// <summary>
		/// The input is a person's name <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TEXTINPUT_TYPE_TEXT_NAME")]
		[NativeName(NativeNameType.Value, "1")]
		Name = unchecked(1),

		/// <summary>
		/// The input is an e-mail address <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TEXTINPUT_TYPE_TEXT_EMAIL")]
		[NativeName(NativeNameType.Value, "2")]
		Email = unchecked(2),

		/// <summary>
		/// The input is a username <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TEXTINPUT_TYPE_TEXT_USERNAME")]
		[NativeName(NativeNameType.Value, "3")]
		Username = unchecked(3),

		/// <summary>
		/// The input is a secure password that is hidden <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TEXTINPUT_TYPE_TEXT_PASSWORD_HIDDEN")]
		[NativeName(NativeNameType.Value, "4")]
		PasswordHidden = unchecked(4),

		/// <summary>
		/// The input is a secure password that is visible <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TEXTINPUT_TYPE_TEXT_PASSWORD_VISIBLE")]
		[NativeName(NativeNameType.Value, "5")]
		PasswordVisible = unchecked(5),

		/// <summary>
		/// The input is a number <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TEXTINPUT_TYPE_NUMBER")]
		[NativeName(NativeNameType.Value, "6")]
		Number = unchecked(6),

		/// <summary>
		/// The input is a secure PIN that is hidden <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TEXTINPUT_TYPE_NUMBER_PASSWORD_HIDDEN")]
		[NativeName(NativeNameType.Value, "7")]
		NumberPasswordHidden = unchecked(7),

		/// <summary>
		/// The input is a secure PIN that is visible <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SDL_TEXTINPUT_TYPE_NUMBER_PASSWORD_VISIBLE")]
		[NativeName(NativeNameType.Value, "8")]
		NumberPasswordVisible = unchecked(8),
	}
}