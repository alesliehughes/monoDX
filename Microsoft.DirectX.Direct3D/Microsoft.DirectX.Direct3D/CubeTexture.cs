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
using System.Drawing;
using System.ComponentModel;
using Microsoft.DirectX.PrivateImplementationDetails;

namespace Microsoft.DirectX.Direct3D
{
	public sealed class CubeTexture : BaseTexture, IDisposable
	{
		public event EventHandler Disposing {
			add {
				throw new NotImplementedException ();
			}
			
			remove {
				throw new NotImplementedException ();
			}
		}

		[CLSCompliant(false)]
		public unsafe IDirect3DCubeTexture9* UnmanagedComPointer {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool Disposed {
			
			get {
				throw new NotImplementedException ();
			}
		}
	
		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator == (CubeTexture left, CubeTexture right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (CubeTexture left, CubeTexture right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}

		public new void Dispose ()
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe CubeTexture (IDirect3DCubeTexture9* pInterop) : base((IntPtr)null)
		{
			throw new NotImplementedException ();
		}

		public unsafe CubeTexture (IntPtr unmanagedObject) : base((IntPtr)null)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe CubeTexture (IDirect3DCubeTexture9* lp, Device device, Pool pool) : base((IntPtr)lp)
		{
			throw new NotImplementedException ();
		}

		public CubeTexture (Device device, int edgeLength, int levels, Usage usage, Format format, Pool pool) : base((IntPtr)null)
		{
			throw new NotImplementedException ();
		}

		public void AddDirtyRectangle (CubeMapFace faceType)
		{
			throw new NotImplementedException ();
		}

		public void AddDirtyRectangle (CubeMapFace faceType, Rectangle rect)
		{
			throw new NotImplementedException ();
		}

		public SurfaceDescription GetLevelDescription (int level)
		{
			throw new NotImplementedException ();
		}

		public Surface GetCubeMapSurface (CubeMapFace faceType, int level)
		{
			throw new NotImplementedException ();
		}

		public GraphicsStream LockRectangle (CubeMapFace faceType, int level, Rectangle rect, LockFlags flags, out int pitch)
		{
			throw new NotImplementedException ();
		}

		public GraphicsStream LockRectangle (CubeMapFace faceType, int level, LockFlags flags, out int pitch)
		{
			throw new NotImplementedException ();
		}

		public GraphicsStream LockRectangle (CubeMapFace faceType, int level, Rectangle rect, LockFlags flags)
		{
			throw new NotImplementedException ();
		}

		public GraphicsStream LockRectangle (CubeMapFace faceType, int level, LockFlags flags)
		{
			throw new NotImplementedException ();
		}

		public Array LockRectangle (Type typeLock, CubeMapFace faceType, int level, Rectangle rect, LockFlags flags, out int pitch, params int[] ranks)
		{
			throw new NotImplementedException ();
		}

		public Array LockRectangle (Type typeLock, CubeMapFace faceType, int level, LockFlags flags, out int pitch, params int[] ranks)
		{
			throw new NotImplementedException ();
		}

		public Array LockRectangle (Type typeLock, CubeMapFace faceType, int level, Rectangle rect, LockFlags flags, params int[] ranks)
		{
			throw new NotImplementedException ();
		}

		public Array LockRectangle (Type typeLock, CubeMapFace faceType, int level, LockFlags flags, params int[] ranks)
		{
			throw new NotImplementedException ();
		}

		public void UnlockRectangle (CubeMapFace faceType, int level)
		{
			throw new NotImplementedException ();
		}

		[EditorBrowsable]
		public IntPtr GetObjectByValue (int uniqueKey)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void UpdateUnmanagedPointer (IDirect3DCubeTexture9* pInterface)
		{
			throw new NotImplementedException ();
			
		}

	}
}
