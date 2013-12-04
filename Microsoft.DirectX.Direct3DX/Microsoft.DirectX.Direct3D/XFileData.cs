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
using Microsoft.DirectX.Direct3DX;
using Microsoft.DirectX.PrivateImplementationDetails;

namespace Microsoft.DirectX.Direct3D
{
	public sealed class XFileData : MarshalByRefObject, IDisposable
	{
		public event EventHandler Disposing {
			add {
				throw new NotImplementedException ();
			}
			remove {
				throw new NotImplementedException ();
			}
		}

		public bool Disposed {
			
			get {
				throw new NotImplementedException ();
			}
		}

		[CLSCompliant(false)]
		public unsafe ID3DXFileData* UnmanagedComPointer {
			get {
				throw new NotImplementedException ();
			}
		}

		public int NumberChildren {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool IsReference {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public Guid Type {
			get {
				throw new NotImplementedException ();
			}
		}

		public Guid Id {
			get {
				throw new NotImplementedException ();
			}
		}

		public string Name {
			get {
				throw new NotImplementedException ();
			}
		}
		
		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator == (XFileData left, XFileData right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (XFileData left, XFileData right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}

		public void Dispose ()
		{
			throw new NotImplementedException ();
		}

		public XFile GetXFile ()
		{
			throw new NotImplementedException ();
		}

		public XFileData GetChild (int index)
		{
			throw new NotImplementedException ();
		}

		public void SetData (object data)
		{
			throw new NotImplementedException ();
		}

		public GraphicsStream Lock ()
		{
			throw new NotImplementedException ();
		}

		public void Unlock ()
		{
			throw new NotImplementedException ();
		}

		[EditorBrowsable]
		public IntPtr GetObjectByValue (int uniqueKey)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe XFileData (ID3DXFileData* pUnk)
		{
			throw new NotImplementedException ();
		}

		public XFileData (IntPtr unmanagedObject)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void UpdateUnmanagedPointer (ID3DXFileData* pInterface)
		{
			throw new NotImplementedException ();
		}
	}
}


