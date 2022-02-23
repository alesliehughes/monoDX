/*
 * The MIT License (MIT)
 *
 * Copyright (c) 2013 Alistair Leslie-Hughes
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of
 * this software and associated documentation files (the "Software"), to deal in
 * the Software without restriction, including without limitation the rights to
 * use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
 * the Software, and to permit persons to whom the Software is furnished to do so,
 * subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
 * FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
 * COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
 * IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
 * CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Microsoft.DirectX.DirectInput
{
	public class Manager : MarshalByRefObject
	{
		internal static IntPtr _dinput;

		[DllImport("monodx.dll", CallingConvention=CallingConvention.Cdecl)]
		internal static extern int dinput_Create([Out] out IntPtr dinput);

		[DllImport("monodx.dll", CallingConvention=CallingConvention.Cdecl)]
		internal static extern void dinput_Release(IntPtr dinput);

		[DllImport("monodx.dll", CallingConvention=CallingConvention.Cdecl)]
		internal static extern int dinput_GetDevices(IntPtr dinput, int devtype, int flags, [Out] out IntPtr result, [Out] out int count);

		public static DeviceList Devices {
			get {
				return GetDevices(DeviceClass.All, EnumDevicesFlags.AllDevices);
			}
		}

		static Manager ()
		{
			Marshal.ThrowExceptionForHR(dinput_Create(out _dinput));
			new Manager();
		}

		internal Manager ()
		{
		}

		public static DeviceList GetDevices (ActionFormat actionFormat, EnumDevicesBySemanticsFlags flags)
		{
			throw new NotImplementedException ();
		}

		public static DeviceList GetDevices (string name, ActionFormat actionFormat, EnumDevicesBySemanticsFlags flags)
		{
			throw new NotImplementedException ();
		}

		internal static DeviceList GetDevices (int deviceType, EnumDevicesFlags flags)
		{
			IntPtr native_devices;
			int count;

			Marshal.ThrowExceptionForHR(dinput_GetDevices(_dinput, deviceType, (int)flags, out native_devices, out count));

			DeviceList result = new DeviceList();
			int disize = Marshal.SizeOf(typeof(DIDEVICEINSTANCE));
			for (int i=0; i<count; i++)
			{
				result.Add(new DeviceInstance((DIDEVICEINSTANCE)Marshal.PtrToStructure(
					IntPtr.Add(native_devices, disize * i), typeof(DIDEVICEINSTANCE))));
			}

			Marshal.FreeCoTaskMem(native_devices);

			return result;
		}

		public static DeviceList GetDevices (DeviceType deviceType, EnumDevicesFlags flags)
		{
			return GetDevices((int)deviceType, flags);
		}

		public static DeviceList GetDevices (DeviceClass deviceType, EnumDevicesFlags flags)
		{
			return GetDevices((int)deviceType, flags);
		}

		public static bool GetDeviceAttached (Guid rguid)
		{
			throw new NotImplementedException ();
		}

		public static void RunControlPanel ()
		{
			throw new NotImplementedException ();
		}

		public static void RunControlPanel (Control owner)
		{
			throw new NotImplementedException ();
		}

		public static Guid FindDevice (Guid guidClass, string name)
		{
			throw new NotImplementedException ();
		}

		public static void ConfigureDevices (ConfigureDevicesParameters @params, ConfigureDevicesFlags flags)
		{
			throw new NotImplementedException ();
		}
	}
}

