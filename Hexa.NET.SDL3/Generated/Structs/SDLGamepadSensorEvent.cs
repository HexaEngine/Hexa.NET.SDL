// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;

namespace Hexa.NET.SDL3
{
	/// <summary>
	/// Gamepad sensor event structure (event.gsensor.*)<br/>
	/// <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDLGamepadSensorEvent
	{
		/// <summary>
		/// SDL_EVENT_GAMEPAD_SENSOR_UPDATE <br/>
		/// </summary>
		public SDLEventType Type;

		public uint Reserved;
		/// <summary>
		/// In nanoseconds, populated using SDL_GetTicksNS() <br/>
		/// </summary>
		public ulong Timestamp;

		/// <summary>
		/// The joystick instance id <br/>
		/// </summary>
		public int Which;

		/// <summary>
		/// The type of the sensor, one of the values of SDL_SensorType <br/>
		/// </summary>
		public int Sensor;

		/// <summary>
		/// Up to 3 values from the sensor, as defined in SDL_sensor.h <br/>
		/// </summary>
		public float Data_0;
		public float Data_1;
		public float Data_2;

		/// <summary>
		/// The timestamp of the sensor reading in nanoseconds, not necessarily synchronized with the system clock <br/>
		/// </summary>
		public ulong SensorTimestamp;


		public unsafe SDLGamepadSensorEvent(SDLEventType type = default, uint reserved = default, ulong timestamp = default, int which = default, int sensor = default, float* data = default, ulong sensorTimestamp = default)
		{
			Type = type;
			Reserved = reserved;
			Timestamp = timestamp;
			Which = which;
			Sensor = sensor;
			if (data != default(float*))
			{
				Data_0 = data[0];
				Data_1 = data[1];
				Data_2 = data[2];
			}
			SensorTimestamp = sensorTimestamp;
		}

		public unsafe SDLGamepadSensorEvent(SDLEventType type = default, uint reserved = default, ulong timestamp = default, int which = default, int sensor = default, Span<float> data = default, ulong sensorTimestamp = default)
		{
			Type = type;
			Reserved = reserved;
			Timestamp = timestamp;
			Which = which;
			Sensor = sensor;
			if (data != default(Span<float>))
			{
				Data_0 = data[0];
				Data_1 = data[1];
				Data_2 = data[2];
			}
			SensorTimestamp = sensorTimestamp;
		}


	}

}
