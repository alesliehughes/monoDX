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
using System.Text;

/*
 * Only Applies to DirectX 2.0
 */
namespace Microsoft.DirectX
{
	public class GraphicsBuffer : IDisposable
	{
		[CLSCompliant(false)]
		public unsafe void* DataBufferPointer {
			get {
				throw new NotImplementedException ();
			}
		}

		public IntPtr DataBuffer {
			get {
				throw new NotImplementedException ();
			}
		}

		public int Position {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public bool CanWrite {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool CanRead {
			get {
				throw new NotImplementedException ();
			}
		}

		public int SlicePitch {
			get {
				throw new NotImplementedException ();
			}
		}

		public int RowPitch {
			get {
				throw new NotImplementedException ();
			}
		}

		public int Pitch {
			get {
				throw new NotImplementedException ();
			}
		}

		public int SizeInBytes {
			get {
				throw new NotImplementedException ();
			}
		}

		public int ElementCount {
			get {
				throw new NotImplementedException ();
			}
		}

		public int ElementSize {
			get {
				throw new NotImplementedException ();
			}
		}

		public GraphicsBuffer (int size)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe GraphicsBuffer (void* pDataPointer, int dataSize, [MarshalAs(UnmanagedType.U1)] bool isReadable, [MarshalAs(UnmanagedType.U1)] bool isWritable)
		{
			throw new NotImplementedException ();
		}

		public GraphicsBuffer (IntPtr dataPointer, int dataSize, [MarshalAs(UnmanagedType.U1)] bool isReadable, [MarshalAs(UnmanagedType.U1)] bool isWritable)
		{
			throw new NotImplementedException ();
		}

		public GraphicsBuffer ()
		{
			throw new NotImplementedException ();
		}

		public static bool IsNullOrEmpty (GraphicsBuffer buffer)
		{
			throw new NotImplementedException ();
		}

		public void AllocateNew (int size)
		{
			throw new NotImplementedException ();
		}

		public void Cleanup ()
		{
			throw new NotImplementedException ();
		}

		public void Read (byte[] buffer)
		{
			throw new NotImplementedException ();
		}

		public void Read (byte[] buffer, int offset, int count)
		{
			throw new NotImplementedException ();
		}

		public void Write (byte[] buffer)
		{
			throw new NotImplementedException ();
		}

		public unsafe void Write (byte[] buffer, int offset, int count)
		{
			throw new NotImplementedException ();
		}

		public void WriteString (string value)
		{
			throw new NotImplementedException ();
		}

		public void WriteString (string value, Encoding encoding)
		{
			throw new NotImplementedException ();
		}

		public string ReadString ()
		{
			throw new NotImplementedException ();
		}

		public string ReadString (Encoding encoding)
		{
			throw new NotImplementedException ();
		}
	
		protected virtual void Dispose(bool flag)
		{
			throw new NotImplementedException ();
		}
		
		public void Dispose()
		{
			throw new NotImplementedException ();
		}

	}
}
