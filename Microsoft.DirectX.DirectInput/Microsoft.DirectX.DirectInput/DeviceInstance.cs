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

namespace Microsoft.DirectX.DirectInput
{
	[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
	internal struct DIDEVICEINSTANCE
	{
		public int dwSize;
		public Guid guidInstance;
		public Guid guidProduct;
		public int dwDevType;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=260)]
		public string tszInstanceName;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=260)]
		public string tszProductName;
		public Guid guidFFDriver;
		public short wUsagePage;
		public short wUsage;
	}

	public struct DeviceInstance
	{
		internal short m_Usage;
		internal short m_UsagePage;
		internal Guid m_FFDriverGuid;
		internal string m_ProductName;
		internal string m_InstanceName;
		internal DeviceType m_DeviceType;
		internal int m_DeviceSubType;
		internal Guid m_ProductGuid;
		internal Guid m_InstanceGuid;

		internal DeviceInstance(DIDEVICEINSTANCE di)
		{
			m_Usage = di.wUsage;
			m_UsagePage = di.wUsagePage;
			m_FFDriverGuid = di.guidFFDriver;
			m_ProductName = di.tszProductName;
			m_InstanceName = di.tszInstanceName;
			m_DeviceType = (DeviceType)(di.dwDevType & 0xff);
			m_DeviceSubType = di.dwDevType >> 8;
			m_ProductGuid = di.guidProduct;
			m_InstanceGuid = di.guidInstance;
		}

		public short Usage {
			get {
				return m_Usage;
			}
		}

		public short UsagePage {
			get {
				return m_UsagePage;
			}
		}

		public Guid FFDriverGuid {
			get {
				return m_FFDriverGuid;
			}
		}

		public string ProductName {
			get {
				return m_ProductName;
			}
		}

		public string InstanceName {
			get {
				return m_InstanceName;
			}
		}

		public int DeviceSubType {
			get {
				return m_DeviceSubType;
			}
		}

		public DeviceType DeviceType {
			get {
				return m_DeviceType;
			}
		}

		public Guid ProductGuid {
			get {
				return m_ProductGuid;
			}
		}

		public Guid InstanceGuid {
			get {
				return m_InstanceGuid;
			}
		}

		public override string ToString ()
		{
			throw new NotImplementedException ();
		}
	}
}

