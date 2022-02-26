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
	public sealed class AdapterInformation
	{
		private int _index;

		public DisplayModeCollection SupportedDisplayModes {
			get => new DisplayModeCollection(_index, Format.X8R8G8B8);
		}

		public DisplayMode CurrentDisplayMode {
			get {
				return Manager.GetAdapterCurrentDisplayMode (_index);
			}
		}

		public AdapterDetails Information {
			get {
				return Manager.GetAdapterIdentifier(_index);
			}
		}

		public int Adapter {
			get => _index;
		}

		public AdapterDetails GetWhqlInformation ()
		{
			throw new NotImplementedException ();
		}

		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			return _index.GetHashCode();
		}

		internal AdapterInformation (int index)
		{
			_index = index;
		}
	}
}

