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
using System.Runtime.InteropServices;

namespace Microsoft.DirectX.Direct3D
{
	public abstract class Resource : IDisposable
	{
		public Pool cachedPool;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual IntPtr NativePointer
		{
			get
			{
				throw new NotImplementedException ();
			}
		}
		public Device Device
		{
			get
			{
				throw new NotImplementedException ();
			}
		}
		public ResourceType Type
		{
			get
			{
				throw new NotImplementedException ();
			}
		}
		public int Priority
		{
			get
			{
				throw new NotImplementedException ();
			}
			set
			{
				throw new NotImplementedException ();
			}
		}
		
		public static bool operator ==(Resource left, Resource right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator !=(Resource left, Resource right)
		{
			throw new NotImplementedException ();
		}
		
		public override bool Equals(object compare)
		{
			throw new NotImplementedException ();
		}
		public override int GetHashCode()
		{
			throw new NotImplementedException ();
		}
		public int SetPriority(int newPriority)
		{
			throw new NotImplementedException ();
		}
		public void PreLoad()
		{
			throw new NotImplementedException ();
		}
		public void SetPrivateData(Guid key, GraphicsBuffer data)
		{
			throw new NotImplementedException ();
		}
		public GraphicsBuffer GetPrivateData(Guid key)
		{
			throw new NotImplementedException ();
		}
		public void FreePrivateData(Guid key)
		{
			throw new NotImplementedException ();
		}

		public override string ToString()
		{
			throw new NotImplementedException ();
		}

		public Resource(IntPtr pInterface)
		{

		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void UpdateNativePointer(IntPtr pInterface)
		{
			throw new NotImplementedException ();
		}

		protected virtual void Dispose(bool flag)
		{
			throw new NotImplementedException ();
		}

		public void Dispose ()
		{
			throw new NotImplementedException ();
		}

	}
}
