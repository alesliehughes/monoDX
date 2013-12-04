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
using Microsoft.DirectX.PrivateImplementationDetails;
using System.ComponentModel;

namespace Microsoft.DirectX.Direct3D
{
	public sealed class VertexBuffer : Resource, IDisposable
	{
		public event EventHandler Disposing {
			
			add {
				throw new NotImplementedException ();
			}
			
			remove {
				throw new NotImplementedException ();
			}
		}

		public event EventHandler Created {
			
			add {
				throw new NotImplementedException ();
			}
			remove {
				throw new NotImplementedException ();
			}
		}

		[CLSCompliant(false)]
		public unsafe IDirect3DVertexBuffer9* UnmanagedComPointer {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool Disposed {
			get {
				throw new NotImplementedException ();
			}
		}

		public int SizeInBytes {
			get {
				throw new NotImplementedException ();
			}
		}

		public VertexBufferDescription Description {
			get {
				throw new NotImplementedException ();
			}
		}

		public new void Dispose ()
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe VertexBuffer (IDirect3DVertexBuffer9* pInterop) : base( (IntPtr)null)
		{
			throw new NotImplementedException ();
		}

		public unsafe VertexBuffer (IntPtr unmanagedObject) : base((IntPtr)null)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe VertexBuffer (IDirect3DVertexBuffer9* lp, Type tType, int iNumVerts, Device device, Usage usage, VertexFormats vertexFormat, Pool Pool) : base((IntPtr)lp)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe VertexBuffer (IDirect3DVertexBuffer9* lp, Device device, Usage usage, VertexFormats vertexFormat, Pool pool) : base((IntPtr)lp)
		{
			throw new NotImplementedException ();
		}

		public VertexBuffer (Device device, int sizeOfBufferInBytes, Usage usage, VertexFormats vertexFormat, Pool pool) : base((IntPtr)null)
		{
			throw new NotImplementedException ();
		}

		public VertexBuffer (Type typeVertexType, int numVerts, Device device, Usage usage, VertexFormats vertexFormat, Pool pool) : base((IntPtr)null)
		{
			throw new NotImplementedException ();
		}

		public Array Lock (int offsetToLock, LockFlags flags)
		{
			throw new NotImplementedException ();
		}

		public GraphicsStream Lock (int offsetToLock, int sizeToLock, LockFlags flags)
		{
			throw new NotImplementedException ();
		}

		public Array Lock (int offsetToLock, Type typeVertex, LockFlags flags, params int[] ranks)
		{
			throw new NotImplementedException ();
		}
	
		public void Unlock ()
		{
			throw new NotImplementedException ();
		}

		public unsafe void SetData (object data, int lockAtOffset, LockFlags flags)
		{
			throw new NotImplementedException ();
		}
		
		[EditorBrowsable]
		public unsafe IntPtr GetObjectByValue (int uniqueKey)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void UpdateUnmanagedPointer (IDirect3DVertexBuffer9* pInterface)
		{
			throw new NotImplementedException ();
		}

	}
}


