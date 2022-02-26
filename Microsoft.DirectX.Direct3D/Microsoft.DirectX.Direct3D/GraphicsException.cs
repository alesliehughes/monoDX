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
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Microsoft.DirectX.Direct3D
{
	[Serializable]
	public class GraphicsException : DirectXException
	{
		protected GraphicsException (SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		public GraphicsException (string message, Exception inner) : base(message, inner)
		{
		}

		public GraphicsException (string message) : base(message)
		{
		}

		public GraphicsException ()
		{
		}

		internal const int DeviceLost = unchecked((int)0x88760868);

		[EditorBrowsable]
		public static new Exception GetExceptionFromResultInternal (int resultCode)
		{
			switch (resultCode)
			{
			case DeviceLost:
				return new DeviceLostException();
			default:
				return new GraphicsException(String.Format("HRESULT {0}", resultCode));
			}
		}

		internal static void CheckHR (int hr)
		{
			if (hr != 0)
			{
				// FIXME: Set DirectXException.LastError?
				if (!IsExceptionIgnored)
				{
					throw GetExceptionFromResultInternal (hr);
				}
			}
		}
	}
}


