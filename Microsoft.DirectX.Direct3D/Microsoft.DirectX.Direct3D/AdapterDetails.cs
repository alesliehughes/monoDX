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

namespace Microsoft.DirectX.Direct3D
{
	public struct AdapterDetails
	{
		private string desc;

		public Guid DeviceIdentifier {
			get {
				throw new NotImplementedException ();
			}
		}

		public int WhqlLevel {
			get {
				throw new NotImplementedException ();
			}
		}

		public int Revision {
			get {
				throw new NotImplementedException ();
			}
		}

		public int SubSystemId {
			get {
				throw new NotImplementedException ();
			}
		}

		public int DeviceId {
			get {
				throw new NotImplementedException ();
			}
		}

		public int VendorId {
			get {
				throw new NotImplementedException ();
			}
		}

		public Version DriverVersion {
			get {
				throw new NotImplementedException ();
			}
		}

		public string DeviceName {
			get {
				throw new NotImplementedException ();
			}
		}

		public string Description {
			get {
				return desc;
			}
		}

		public string DriverName {
			get {
				throw new NotImplementedException ();
			}
		}

		public override string ToString ()
		{
			throw new NotImplementedException ();
		}

		internal AdapterDetails (string description)
		{
			this.desc = description;
		}
	}
}