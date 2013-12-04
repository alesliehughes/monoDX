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
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Microsoft.DirectX
{
	[Serializable]
	public sealed class GraphicsStream : Stream, IDisposable
	{
		[CLSCompliant(false)]
		public unsafe void* InternalBufferPointer {
			get {
				throw new NotImplementedException ();
			}
		}

		[CLSCompliant(false)]
		public unsafe void* InternalDataPointer {
			get {
				throw new NotImplementedException ();
			}
		}

		public IntPtr InternalBuffer {
			get {
				throw new NotImplementedException ();
			}
		}

		public IntPtr InternalData {
			get {
				throw new NotImplementedException ();
			}
		}

		public override long Position {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public override long Length {
			get {
				throw new NotImplementedException ();
			}
		}

		public override bool CanSeek {
			get {
				throw new NotImplementedException ();
			}
		}

		public override bool CanWrite {
            
			get {
				throw new NotImplementedException ();
			}
		}

		public override bool CanRead {
            
			get {
				throw new NotImplementedException ();
			}
		}

		public GraphicsStream (IntPtr dataPointer, long size, [MarshalAs(4)] bool read, [MarshalAs(4)] bool write)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe GraphicsStream (void* pDataPointer, long size, [MarshalAs(4)] bool read, [MarshalAs(4)] bool write)
		{
			throw new NotImplementedException ();
		}

		public unsafe GraphicsStream (IntPtr dataPointer, long size, IntPtr bufferPointer)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe GraphicsStream (void* pDataPointer, long size, void* bufferPointer)
		{
			throw new NotImplementedException ();
		}
   
		public string Read (bool unicode)
		{
			throw new NotImplementedException ();
		}

		public Array Read (Type returnType, params int[] ranks)
		{
			throw new NotImplementedException ();
		}

		public ValueType Read (Type returnType)
		{
			throw new NotImplementedException ();
		}

		public  override int Read (byte[] buffer, int offset, int count)
		{
			throw new NotImplementedException ();
		}

		public void Write (string value)
		{
			throw new NotImplementedException ();
		}

		public void Write (string value, [MarshalAs(4)] bool isUnicodeString)
		{
			throw new NotImplementedException ();
		}

		public void Write (Array value)
		{
			throw new NotImplementedException ();
		}

		public void Write (ValueType value)
		{
			throw new NotImplementedException ();
		}

		public override void Write (byte[] buffer, int offset, int count)
		{
			throw new NotImplementedException ();
		}

		public override long Seek (long newposition, SeekOrigin origin)
		{
			throw new NotImplementedException ();
		}

		public override void SetLength (long newLength)
		{
			throw new NotImplementedException ();
		}

		public override void Flush ()
		{
			throw new NotImplementedException ();
		}

		public override void Close ()
		{
			throw new NotImplementedException ();
		}
        
		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}

	}
}
