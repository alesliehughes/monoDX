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

namespace Microsoft.DirectX.DirectInput
{
	public class DeviceProperties
	{
		public int JoystickId {
			get {
				throw new NotImplementedException ();
			}
		}

		public string PortDisplayName {
			get {
				throw new NotImplementedException ();
			}
		}

		public int ForceFeedbackLoad {
			get {
				throw new NotImplementedException ();
			}
		}

		public int VendorIdentityProductId {
			get {
				throw new NotImplementedException ();
			}
		}

		public string UserName {
			get {
				throw new NotImplementedException ();
			}
		}

		public string TypeName {
			get {
				throw new NotImplementedException ();
			}
		}

		public string ProductName {
			get {
				throw new NotImplementedException ();
			}
		}

		public int ForceFeedbackGain {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public int BufferSize {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public bool AxisModeAbsolute {
			get {
				throw new NotImplementedException ();
			}

			set {
				throw new NotImplementedException ();
			}
		}

		public bool AutoCenter {
			get {
				throw new NotImplementedException ();
			}
			
			set {
				throw new NotImplementedException ();
			}
		}

		public object GetApplicationData (ParameterHow how, int objectId)
		{
			throw new NotImplementedException ();
		}

		public void SetApplicationData (ParameterHow how, int objectId, object value)
		{
			throw new NotImplementedException ();
		}

		public CalibrationPoint[] GetCalibrationPoints (ParameterHow how, int objectId)
		{
			throw new NotImplementedException ();
		}

		public void SetCalibrationPoints (ParameterHow how, int objectId, CalibrationPoint[] value)
		{
			throw new NotImplementedException ();
		}

		public int GetDeadZone (ParameterHow how, int objectId)
		{
			throw new NotImplementedException ();
		}

		public void SetDeadZone (ParameterHow how, int objectId, int value)
		{
			throw new NotImplementedException ();
		}

		public int GetGranularity (ParameterHow how, int objectId)
		{
			throw new NotImplementedException ();
		}

		public string GetKeyName (ParameterHow how, int objectId)
		{
			throw new NotImplementedException ();
		}

		public InputRange GetRange (ParameterHow how, int objectId)
		{
			throw new NotImplementedException ();
		}

		public void SetRange (ParameterHow how, int objectId, InputRange value)
		{
			throw new NotImplementedException ();
		}

		public InputRange GetLogicalRange (ParameterHow how, int objectId)
		{
			throw new NotImplementedException ();
		}

		public InputRange GetPhysicalRange (ParameterHow how, int objectId)
		{
			throw new NotImplementedException ();
		}

		public int GetSaturation (ParameterHow how, int objectId)
		{
			throw new NotImplementedException ();
		}

		public void SetSaturation (ParameterHow how, int objectId, int value)
		{
			throw new NotImplementedException ();
		}

		public int GetScanCode (ParameterHow how, int objectId)
		{
			throw new NotImplementedException ();
		}
	}
}

