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
	/// The different sensors defined by SDL.<br/>
	/// Additional sensors may be available, using platform dependent semantics.<br/>
	/// Here are the additional Android sensors:<br/>
	/// https://developer.android.com/reference/android/hardware/SensorEvent.html#values<br/>
	/// Accelerometer sensor notes:<br/>
	/// The accelerometer returns the current acceleration in SI meters per second<br/>
	/// squared. This measurement includes the force of gravity, so a device at<br/>
	/// rest will have an value of SDL_STANDARD_GRAVITY away from the center of the<br/>
	/// earth, which is a positive Y value.<br/>
	/// - `values[0]`: Acceleration on the x axis<br/>
	/// - `values[1]`: Acceleration on the y axis<br/>
	/// - `values[2]`: Acceleration on the z axis<br/>
	/// For phones and tablets held in natural orientation and game controllers<br/>
	/// held in front of you, the axes are defined as follows:<br/>
	/// - -X ... +X : left ... right<br/>
	/// - -Y ... +Y : bottom ... top<br/>
	/// - -Z ... +Z : farther ... closer<br/>
	/// The accelerometer axis data is not changed when the device is rotated.<br/>
	/// Gyroscope sensor notes:<br/>
	/// The gyroscope returns the current rate of rotation in radians per second.<br/>
	/// The rotation is positive in the counter-clockwise direction. That is, an<br/>
	/// observer looking from a positive location on one of the axes would see<br/>
	/// positive rotation on that axis when it appeared to be rotating<br/>
	/// counter-clockwise.<br/>
	/// - `values[0]`: Angular speed around the x axis (pitch)<br/>
	/// - `values[1]`: Angular speed around the y axis (yaw)<br/>
	/// - `values[2]`: Angular speed around the z axis (roll)<br/>
	/// For phones and tablets held in natural orientation and game controllers<br/>
	/// held in front of you, the axes are defined as follows:<br/>
	/// - -X ... +X : left ... right<br/>
	/// - -Y ... +Y : bottom ... top<br/>
	/// - -Z ... +Z : farther ... closer<br/>
	/// The gyroscope axis data is not changed when the device is rotated.<br/>
	/// <br/>
	/// <br/>
	/// </summary>
	[Flags]
	public enum SDLSensorType : int
	{
		/// <summary>
		/// Returned for an invalid sensor <br/>
		/// </summary>
		Invalid = unchecked(-1),

		/// <summary>
		/// Unknown sensor type <br/>
		/// </summary>
		Unknown = unchecked(0),

		/// <summary>
		/// Accelerometer <br/>
		/// </summary>
		Accel = unchecked(1),

		/// <summary>
		/// Gyroscope <br/>
		/// </summary>
		Gyro = unchecked(2),

		/// <summary>
		/// Accelerometer for left Joy-Con controller and Wii nunchuk <br/>
		/// </summary>
		AccelL = unchecked(3),

		/// <summary>
		/// Gyroscope for left Joy-Con controller <br/>
		/// </summary>
		GyroL = unchecked(4),

		/// <summary>
		/// Accelerometer for right Joy-Con controller <br/>
		/// </summary>
		AccelR = unchecked(5),

		/// <summary>
		/// Gyroscope for right Joy-Con controller <br/>
		/// </summary>
		GyroR = unchecked(6),
	}
}
