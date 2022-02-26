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

namespace Microsoft.DirectX.Direct3D
{
	public struct AdapterDetails
	{
		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		internal struct D3DADAPTER_IDENTIFIER9
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=512)]
			public string Driver;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=512)]
			public string Description;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=32)]
			public string DeviceName;
			public ulong DriverVersion;
			public int VendorId;
			public int DeviceId;
			public int SubSysId;
			public int Revision;
			public Guid DeviceIdentifier;
			public int WHQLLevel;
		}

		private D3DADAPTER_IDENTIFIER9 info;

		public Guid DeviceIdentifier {
			get {
				return info.DeviceIdentifier;
			}
		}

		public int WhqlLevel {
			get {
				return info.WHQLLevel;
			}
		}

		public int Revision {
			get {
				return info.Revision;
			}
		}

		public int SubSystemId {
			get {
				return info.SubSysId;
			}
		}

		public int DeviceId {
			get {
				return info.DeviceId;
			}
		}

		public int VendorId {
			get {
				return info.VendorId;
			}
		}

		public Version DriverVersion {
			get {
				ulong ver = info.DriverVersion;
				return new Version((int)(ver >> 48), (int)((ver >> 32)&0xffff), (int)((ver >>16)&0xffff), (int)(ver&0xffff));
			}
		}

		public string DeviceName {
			get {
				return info.DeviceName;
			}
		}

		public string Description {
			get {
				return info.Description;
			}
		}

		public string DriverName {
			get {
				return info.Driver;
			}
		}

		public override string ToString ()
		{
			return string.Format(
				"DeviceIdentifier: {0}\nWhqlLevel: {1}\nRevision: {2}\nSubSystemId: {3}\nDeviceId: {4}\nVendorId: {5}\nDriverVersion: {6}\nDeviceName: {7}\nDescription: {8}\nDriverName: {9}\n",
				DeviceIdentifier, WhqlLevel, Revision, SubSystemId, DeviceId, VendorId, DriverVersion, DeviceName, Description, DriverName);
		}

		internal AdapterDetails (D3DADAPTER_IDENTIFIER9 info)
		{
			this.info = info;
		}
	}
}
