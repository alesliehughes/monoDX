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
	public sealed class Volume : MarshalByRefObject, IDisposable
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
		public unsafe IDirect3DVolume9* UnmanagedComPointer {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool Disposed {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public VolumeDescription Description {
			get {
				throw new NotImplementedException ();
			}
		}

		public Device Device {
			get {
				throw new NotImplementedException ();
			}
		}

		public void Dispose ()
		{
			throw new NotImplementedException ();
		}

		public GraphicsStream LockBox (Box box, LockFlags flags, out LockedBox lockedVolume)
		{
			throw new NotImplementedException ();
		}

		public GraphicsStream LockBox (LockFlags flags, out LockedBox lockedVolume)
		{
			throw new NotImplementedException ();
		}

		public GraphicsStream LockBox (Box box, LockFlags flags)
		{
			throw new NotImplementedException ();
		}

		public GraphicsStream LockBox (LockFlags flags)
		{
			throw new NotImplementedException ();
		}

		public Array LockBox (Type typeLock, Box box, LockFlags flags, out LockedBox lockedVolume, params int[] ranks)
		{
			throw new NotImplementedException ();
		}

		public Array LockBox (Type typeLock, LockFlags flags, out LockedBox lockedVolume, params int[] ranks)
		{
			throw new NotImplementedException ();
		}

		public Array LockBox (Type typeLock, Box box, LockFlags flags, params int[] ranks)
		{
			throw new NotImplementedException ();
		}

		public Array LockBox (Type typeLock, LockFlags flags, params int[] ranks)
		{
			throw new NotImplementedException ();
		}

		public void UnlockBox ()
		{
			throw new NotImplementedException ();
		}

		public object GetContainer (Guid interfaceId)
		{
			throw new NotImplementedException ();
		}

		public void SetPrivateData (Guid guidData, byte[] privateData)
		{
			throw new NotImplementedException ();
		}

		public byte[] GetPrivateData (Guid guidData)
		{
			throw new NotImplementedException ();
		}

		public void FreePrivateData (Guid guidData)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe Volume (IDirect3DVolume9* pUnk)
		{
			throw new NotImplementedException ();
		}

		public unsafe Volume (IntPtr unmanagedObject)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe Volume (IDirect3DVolume9* lp, VolumeTexture device)
		{
			throw new NotImplementedException ();
		}
		
		[EditorBrowsable]
		public IntPtr GetObjectByValue (int uniqueKey)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void UpdateUnmanagedPointer (IDirect3DVolume9* pInterface)
		{
			throw new NotImplementedException ();
		}
	
	}
}
