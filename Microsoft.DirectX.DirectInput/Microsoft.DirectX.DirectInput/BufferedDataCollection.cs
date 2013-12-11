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
using System.Collections;

namespace Microsoft.DirectX.DirectInput
{
	public class BufferedDataCollection : IEnumerable, ICloneable
	{
		public BufferedData this [int index] {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public object SyncRoot {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool IsSynchronized {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public int Count {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool IsReadOnly {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public bool IsFixedSize {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public BufferedDataCollection ()
		{
			throw new NotImplementedException ();
		}

		public void SortBySequence (bool Descending)
		{
			throw new NotImplementedException ();
		}

		public void SortBySequence ()
		{
			throw new NotImplementedException ();
		}

		public int DeviceDataSum (int offset)
		{
			throw new NotImplementedException ();
		}

		public int DeviceDataSum (object applicationData)
		{
			throw new NotImplementedException ();
		}

		public int DeviceDataAverage (int offset)
		{
			throw new NotImplementedException ();
		}

		public int DeviceDataAverage (object applicationData)
		{
			throw new NotImplementedException ();
		}

		public int DeviceDataInstanceCount (int offset)
		{
			throw new NotImplementedException ();
		}

		public int DeviceDataInstanceCount (object applicationData)
		{
			throw new NotImplementedException ();
		}

		public void CopyTo (Array data, int index)
		{
			throw new NotImplementedException ();
		}

		public void Clear ()
		{
			throw new NotImplementedException ();
		}
		
		public bool Contains (object obj)
		{
			throw new NotImplementedException ();
		}
		
		public bool Contains (BufferedData value)
		{
			throw new NotImplementedException ();
		}

		public int IndexOf (object obj)
		{
			throw new NotImplementedException ();
		}

		public int IndexOf (BufferedData value)
		{
			throw new NotImplementedException ();
		}

		public int Add (object value)
		{
			throw new NotImplementedException ();
		}

		public void Insert (int x, object obj)
		{
			throw new NotImplementedException ();
		}

		public void Remove (object obj)
		{
			throw new NotImplementedException ();
		}

		public void Remove (BufferedData value)
		{
			throw new NotImplementedException ();
		}

		public void RemoveAt (int index)
		{
			throw new NotImplementedException ();
		}

		public IEnumerator GetEnumerator ()
		{
			throw new NotImplementedException ();
		}

		public object Clone ()
		{
			throw new NotImplementedException ();
		}
	}
}

