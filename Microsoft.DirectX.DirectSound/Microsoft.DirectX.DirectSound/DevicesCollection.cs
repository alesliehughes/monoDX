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
using System.Collections;
using System.Runtime.InteropServices;

namespace Microsoft.DirectX.DirectSound
{
	public sealed class DevicesCollection : IEnumerable, IEnumerator
	{
		ArrayList m_devices;
		int m_index;

		public DeviceInformation this [int index] {
			get {
				return (DeviceInformation)m_devices[index];
			}
		}

		public int Count {
			get {
				if (m_devices != null)
				{
					return m_devices.Count;
				}

				return -1;
			}
		}

		public object Current {
			get {
				if (m_devices != null || m_devices.Count == 0)
				{
					return null;
				}

				if (m_index >= 0)
					return m_devices[m_index];

				return null;
			}
		}

		[UnmanagedFunctionPointerAttribute(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I4)]
		delegate bool ds_enum_cb(UIntPtr guid, [MarshalAs(UnmanagedType.LPWStr)] string desc, [MarshalAs(UnmanagedType.LPWStr)] string module, IntPtr context);

		[DllImport("dsound.dll", CallingConvention=CallingConvention.StdCall)]
		extern static int DirectSoundEnumerateW([MarshalAs(UnmanagedType.FunctionPtr)] ds_enum_cb func , IntPtr context);

		private bool my_enum(UIntPtr guid, string desc, string module, IntPtr context)
		{
			DeviceInformation info = new DeviceInformation();
			Guid local = new Guid();

			if(guid != null)
				return true;

			info.m_modulename = module;
			info.m_description = desc;

			if(guid != null)
			{
				local = Guid.NewGuid(); // FIXME("Convert UIntPtr to GUID");
			}
			info.m_driver = local;

			m_devices.Add(info);

			return true;
		}

		public DevicesCollection ()
		{
			System.IntPtr va = (IntPtr)0;

			m_index = -1;

			ds_enum_cb del = this.my_enum;

			m_devices = new ArrayList();

			DirectSoundEnumerateW(del, va);
		}

		public void Reset ()
		{
			m_index = -1;
		}

		public bool MoveNext ()
		{
			if (m_devices == null || m_index+1 > m_devices.Count - 1)
				return false;

			m_index++;

			return true;
		}

		public IEnumerator GetEnumerator ()
		{
			return this;
		}
	}
}

