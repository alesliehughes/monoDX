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

namespace Microsoft.DirectX.Direct3D
{
	public sealed class PresentParameters : ICloneable
	{
		[StructLayout(LayoutKind.Sequential)]
		internal struct D3DPRESENT_PARAMETERS
		{
			public int BackBufferWidth;
			public int BackBufferHeight;
			public int BackBufferFormat;
			public int BackBufferCount;
			public int MultiSampleType;
			public int MultiSampleQuality;
			public int SwapEffect;
			public IntPtr hDeviceWindow;
			public bool Windowed;
			public bool EnableAutoDepthStencil;
			public int AutoDepthStencilFormat;
			public int Flags;
			public int FullScreen_RefreshRateInHz;
			public int PresentationInterval;
		}

		internal D3DPRESENT_PARAMETERS _params;

		private Control deviceWindowControl;

		public int MultiSampleQuality {
			get {
				return _params.MultiSampleQuality;
			}
			set {
				_params.MultiSampleQuality = value;
			}
		}

		public PresentInterval PresentationInterval {
			get {
				return (PresentInterval)_params.PresentationInterval;
			}
			set {
				_params.PresentationInterval = (int)value;
			}
		}

		public int FullScreenRefreshRateInHz {
			get {
				return _params.FullScreen_RefreshRateInHz;
			}
			set {
				_params.FullScreen_RefreshRateInHz = value;
			}
		}

		public PresentFlag PresentFlag {
			get {
				return (PresentFlag)_params.Flags;
			}
			set {
				_params.Flags = (int)value;
			}
		}

		public DepthFormat AutoDepthStencilFormat {
			get {
				return (DepthFormat)_params.AutoDepthStencilFormat;
			}
			set {
				_params.AutoDepthStencilFormat = (int)value;
			}
		}

		public bool EnableAutoDepthStencil {
			get {
				return _params.EnableAutoDepthStencil;
			}
			set {
				_params.EnableAutoDepthStencil = value;
			}
		}

		public bool Windowed {
			get {
				return _params.Windowed;
			}
			set {
				_params.Windowed = value;
			}
		}

		public IntPtr DeviceWindowHandle {
			get {
				return _params.hDeviceWindow;
			}
			set {
				_params.hDeviceWindow = value;
				deviceWindowControl = null;
			}
		}

		public Control DeviceWindow {
			get {
				return deviceWindowControl;
			}
			set {
				if (value != null)
				{
					DeviceWindowHandle = value.Handle;
					deviceWindowControl = value;
				}
				else
					DeviceWindowHandle = IntPtr.Zero;
			}
		}

		public SwapEffect SwapEffect {
			get {
				return (SwapEffect)_params.SwapEffect;
			}
			set {
				_params.SwapEffect = (int)value;
			}
		}

		public MultiSampleType MultiSample {
			get {
				return (MultiSampleType)_params.MultiSampleType;
			}
			set {
				_params.MultiSampleType = (int)value;
			}
		}

		public int BackBufferCount {
			get {
				return _params.BackBufferCount;
			}
			set {
				_params.BackBufferCount = value;
			}
		}

		public Format BackBufferFormat {
			get {
				return (Format)_params.BackBufferFormat;
			}
			set {
				_params.BackBufferFormat = (int)value;
			}
		}

		public int BackBufferHeight {
			get {
				return _params.BackBufferHeight;
			}
			set {
				_params.BackBufferHeight = value;
			}
		}

		public int BackBufferWidth {
			get {
				return _params.BackBufferWidth;
			}
			set {
				_params.BackBufferWidth = value;
			}
		}

		public bool ForceNoMultiThreadedFlag {
			get {
				throw new NotImplementedException ();
			}

			set {
				throw new NotImplementedException ();
			}
		}

		public PresentParameters ()
		{
		}

		public PresentParameters (PresentParameters original)
		{
			_params = original._params;
			deviceWindowControl = original.deviceWindowControl;
		}

		public object Clone ()
		{
			return new PresentParameters(this);
		}

		public override string ToString ()
		{
			throw new NotImplementedException ();
		}
	}
}
