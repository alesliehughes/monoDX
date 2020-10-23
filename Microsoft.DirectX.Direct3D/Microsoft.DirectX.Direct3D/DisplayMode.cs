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
	public struct DisplayMode
	{
		[StructLayout(LayoutKind.Sequential)]
		internal struct D3DDISPLAYMODE {
    			public uint Width;
    			public uint Height;
    			public uint RefreshRate;
    			public uint Format;
		}

		private D3DDISPLAYMODE _mode;

		internal DisplayMode(D3DDISPLAYMODE mode)
		{
			_mode = mode;
		}

		public int Height {
			get => (int)_mode.Height;
			set => _mode.Height = (uint)value;
		}

		public int Width {
			get => (int)_mode.Width;
			set => _mode.Width = (uint)value;
		}

		public int RefreshRate {
			get => (int)_mode.RefreshRate;
			set => _mode.RefreshRate = (uint)value;
		}

		public Format Format {
			get => (Format)_mode.Format;
			set => _mode.Format = (uint)value;
		}

		public override string ToString ()
		{
			throw new NotImplementedException ();
		}
	}
}