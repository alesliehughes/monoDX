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
using System.Runtime.InteropServices;
using Microsoft.DirectX.PrivateImplementationDetails;

namespace Microsoft.DirectX.Direct3D
{
	public sealed class StateBlock : MarshalByRefObject, IDisposable
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
		public unsafe IDirect3DStateBlock9* UnmanagedComPointer {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool Disposed {
	
			get {
				throw new NotImplementedException ();
			}
		}

		public Device Device {
			get {
				throw new NotImplementedException ();
			}
		}

		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator == (StateBlock left, StateBlock right)
		{
			throw new NotImplementedException ();
		}

		public static bool operator != (StateBlock left, StateBlock right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe StateBlock (IDirect3DStateBlock9* pUnk)
		{
			throw new NotImplementedException ();
		}

		public StateBlock (IntPtr unmanagedObject)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe StateBlock (IDirect3DStateBlock9* lp, Device device)
		{
			throw new NotImplementedException ();
		}

		public StateBlock (Device device, StateBlockType stateBlockType)
		{
			throw new NotImplementedException ();
		}

		public void Dispose ()
		{
			throw new NotImplementedException ();
		}

		public void Capture ()
		{
			throw new NotImplementedException ();
		}

		public void Apply ()
		{
			throw new NotImplementedException ();
		}

		[EditorBrowsable]
		public IntPtr GetObjectByValue (int uniqueKey)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void UpdateUnmanagedPointer (IDirect3DStateBlock9* pInterface)
		{
			throw new NotImplementedException ();
		}
		

	}
}
