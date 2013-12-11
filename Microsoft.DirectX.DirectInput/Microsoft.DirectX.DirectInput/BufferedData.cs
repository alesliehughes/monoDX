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

#pragma warning disable 660 661

namespace Microsoft.DirectX.DirectInput
{
	public class BufferedData
	{
		public object ApplicationData {
			get {
				throw new NotImplementedException ();
			}
		}

		public int Sequence {
			get {
				throw new NotImplementedException ();
			}
		}

		public int TimeStamp {
			get {
				throw new NotImplementedException ();
			}
		}

		public int ButtonPressedData {
			get {
				throw new NotImplementedException ();
			}
		}

		public int Data {
			get {
				throw new NotImplementedException ();
			}
		}

		public int Offset {
			get {
				throw new NotImplementedException ();
			}
		}

		public static bool operator == (BufferedData a, BufferedData b)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator > (BufferedData a, BufferedData b)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator >= (BufferedData a, BufferedData b)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (BufferedData a, BufferedData b)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator < (BufferedData a, BufferedData b)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator <= (BufferedData a, BufferedData b)
		{
			throw new NotImplementedException ();
		}
		
		public static bool op_LogicalAnd (BufferedData a, BufferedData b)
		{
			throw new NotImplementedException ();
		}
		
		public static bool op_LogicalOr (BufferedData a, BufferedData b)
		{
			throw new NotImplementedException ();
		}
	}
}

