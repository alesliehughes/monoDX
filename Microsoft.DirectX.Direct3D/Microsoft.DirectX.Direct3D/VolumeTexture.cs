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
using Microsoft.DirectX.PrivateImplementationDetails;


namespace Microsoft.DirectX.Direct3D
{
	public sealed class VolumeTexture : BaseTexture, IDisposable
	{
		public event EventHandler Disposing
		{
			
			add
			{
				throw new NotImplementedException ();
			}
		
			remove
			{
				throw new NotImplementedException ();
			}
		}
		[CLSCompliant(false)]
		public unsafe IDirect3DVolumeTexture9* UnmanagedComPointer
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
		
		public override bool Equals(object compare)
		{
		throw new NotImplementedException ();
		}
		
		public static bool operator ==(VolumeTexture left, VolumeTexture right)
		{
			throw new NotImplementedException ();
		}
	
		public static bool operator !=(VolumeTexture left, VolumeTexture right)
		{
			throw new NotImplementedException ();
		}
		public override int GetHashCode()
		{
			throw new NotImplementedException ();
		}
		public new void Dispose()
		{
			throw new NotImplementedException ();
		}
		[CLSCompliant(false)]
		public unsafe VolumeTexture(IDirect3DVolumeTexture9* pInterop) : base((IntPtr)null)
		{
			throw new NotImplementedException ();
		}
		public unsafe VolumeTexture(IntPtr unmanagedObject) : base((IntPtr)null)
		{
			throw new NotImplementedException ();
		}
		[CLSCompliant(false)]
		public unsafe VolumeTexture(IDirect3DVolumeTexture9* lp, Device device, Pool pool) : base((IntPtr)lp)
		{
			throw new NotImplementedException ();
		}
		public VolumeTexture(Device device, int width, int height, int depth, int numLevels, Usage usage, Format format, Pool pool) : base((IntPtr)null)
		{
			throw new NotImplementedException ();
		}
		public void AddDirtyBox(Box box)
		{
			throw new NotImplementedException ();
		}
		public void AddDirtyBox()
		{
		throw new NotImplementedException ();
		}
		public VolumeDescription GetLevelDescription(int level)
		{
			throw new NotImplementedException ();
		}
		public GraphicsStream LockBox(int level, Box box, LockFlags flags, out LockedBox lockedVolume)
		{
			throw new NotImplementedException ();
		}
		public GraphicsStream LockBox(int level, LockFlags flags, out LockedBox lockedVolume)
		{
			throw new NotImplementedException ();
		}
		public GraphicsStream LockBox(int level, Box box, LockFlags flags)
		{
			throw new NotImplementedException ();
		}
		public GraphicsStream LockBox(int level, LockFlags flags)
		{
			throw new NotImplementedException ();
		}
		public Array LockBox(Type typeLock, int level, Box box, LockFlags flags, out LockedBox lockedVolume, params int[] ranks)
		{
		throw new NotImplementedException ();
		}
		public Array LockBox(Type typeLock, int level, LockFlags flags, out LockedBox lockedVolume, params int[] ranks)
		{
			throw new NotImplementedException ();
		}
		public Array LockBox(Type typeLock, int level, Box box, LockFlags flags, params int[] ranks)
		{
		throw new NotImplementedException ();
		}
		public Array LockBox(Type typeLock, int level, LockFlags flags, params int[] ranks)
		{
			throw new NotImplementedException ();
		}
		public void UnlockBox(int level)
		{
			throw new NotImplementedException ();
		}
		public Volume GetVolumeLevel(int level)
		{
			throw new NotImplementedException ();
		}

	
		[EditorBrowsable]
		public IntPtr GetObjectByValue(int uniqueKey)
		{
		throw new NotImplementedException ();
		}
		[CLSCompliant(false)]
		public unsafe void UpdateUnmanagedPointer(IDirect3DVolumeTexture9* pInterface)
		{
			throw new NotImplementedException ();
		}

	}
}
