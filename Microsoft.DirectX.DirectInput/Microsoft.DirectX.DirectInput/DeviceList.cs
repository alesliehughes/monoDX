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
using System.Collections;

namespace Microsoft.DirectX.DirectInput
{
	public sealed class DeviceList : IEnumerable, IEnumerator
	{
		private ArrayList m_devices;
		private int m_index;

		internal DeviceList()
		{
			m_devices = new ArrayList();
			m_index = -1;
		}

		internal void Add(object obj)
		{
			m_devices.Add(obj);
		}

		public int Count {
			get {
				return m_devices.Count;
			}
		}

		public object Current {
			get {
				if (m_devices.Count == 0)
					return null;

				return m_devices[m_index];
			}
		}

		public void Reset ()
		{
			m_index = -1;
		}

		[return: MarshalAs(UnmanagedType.U1)]
		public bool MoveNext ()
		{
			if (m_devices.Count == 0 || m_index == m_devices.Count - 1)
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

