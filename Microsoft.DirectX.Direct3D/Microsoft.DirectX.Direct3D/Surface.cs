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
using System.Runtime.CompilerServices;
using System.Drawing;
using System.IO;
using Microsoft.DirectX.PrivateImplementationDetails;

namespace Microsoft.DirectX.Direct3D
{
	public sealed class Surface : Resource, IDisposable
	{
		/*public event EventHandler Disposing
		{
			[MethodImpl(32)]
			add
			{
				throw new NotImplementedException ();
			}
			[MethodImpl(32)]
			remove
			{
				throw new NotImplementedException ();
			}
		}*/
		[CLSCompliant(false)]
		public unsafe IDirect3DSurface9* UnmanagedComPointer
		{
			get
			{
				throw new NotImplementedException ();
			}
		}
		public bool Disposed
		{
			get
			{
				throw new NotImplementedException ();
			}
		}

		public SurfaceDescription Description
		{
			get
			{
				throw new NotImplementedException ();
			}
		}
		public new void Dispose()
		{
			throw new NotImplementedException ();
		}
		[CLSCompliant(false)]
		public unsafe Surface(IDirect3DSurface9* pInterop) : base( (IntPtr)null)
		{
			throw new NotImplementedException ();
		}
		public Surface(IntPtr unmanagedObject) : base( (IntPtr)null)
		{
			throw new NotImplementedException ();
		}
		[CLSCompliant(false)]
		public unsafe Surface(IDirect3DSurface9* lp, object device) : base( (IntPtr)lp)
		{
			throw new NotImplementedException ();
		}
		public Surface(Device device, Stream data, Pool pool) : base( (IntPtr)null)
		{
			throw new NotImplementedException ();
		}
		public Surface(Device device, Bitmap image, Pool pool) : base( (IntPtr)null)
		{
			throw new NotImplementedException ();
		}
		public static Surface FromBitmap(Device device, Bitmap image, Pool pool)
		{
			throw new NotImplementedException ();
		}
		public static Surface FromStream(Device device, Stream data, Pool pool)
		{
			throw new NotImplementedException ();
		}

		public Graphics GetGraphics()
		{
			throw new NotImplementedException ();
		}
		public GraphicsStream LockRectangle(Rectangle rect, LockFlags flags, out int pitch)
		{
			throw new NotImplementedException ();
		}
		public GraphicsStream LockRectangle(LockFlags flags, out int pitch)
		{
			throw new NotImplementedException ();
		}
		public GraphicsStream LockRectangle(Rectangle rect, LockFlags flags)
		{
			throw new NotImplementedException ();
		}
		public GraphicsStream LockRectangle(LockFlags flags)
		{
			throw new NotImplementedException ();
		}
		public Array LockRectangle(Type typeLock, Rectangle rect, LockFlags flags, out int pitch, params int[] ranks)
		{
			throw new NotImplementedException ();
		}
		public Array LockRectangle(Type typeLock, LockFlags flags, out int pitch, params int[] ranks)
		{
			throw new NotImplementedException ();
		}
		public Array LockRectangle(Type typeLock, Rectangle rect, LockFlags flags, params int[] ranks)
		{
			throw new NotImplementedException ();
		}
		public Array LockRectangle(Type typeLock, LockFlags flags, params int[] ranks)
		{
			throw new NotImplementedException ();
		}
		public void UnlockRectangle()
		{
			throw new NotImplementedException ();
		}
		public void ReleaseGraphics()
		{
			throw new NotImplementedException ();
		}
		public object GetContainer(Guid interfaceId)
		{
			throw new NotImplementedException ();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public IntPtr GetObjectByValue(int uniqueKey)
		{
			throw new NotImplementedException ();
		}
		[CLSCompliant(false)]
		public unsafe void UpdateUnmanagedPointer(IDirect3DSurface9* pInterface)
		{
			throw new NotImplementedException ();
		}

	}
}
