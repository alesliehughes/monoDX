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
using System.Windows.Forms;

namespace Microsoft.DirectX.DirectSound
{
	public class Device : MarshalByRefObject, IDisposable
	{
		private Guid guid;

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

		public Speakers SpeakerConfig {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public bool Certified {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public Caps Caps {
			get {
				throw new NotImplementedException ();
			}
		}
		
		public override bool Equals (object compare)
		{
			if (compare is Device device)
			{
				return this == device;
			}

			return false;
		}
		
		public static bool operator == (Device left, Device right)
		{
			if (left is null)
				return (right is null);
			if (right is null)
				return false;
			return left.guid == right.guid;
		}
		
		public static bool operator != (Device left, Device right)
		{
			return !(left == right);
		}

		public override int GetHashCode ()
		{
			return guid.GetHashCode();
		}

		public Device (IntPtr lp)
		{
			throw new NotImplementedException ();
		}

		public Device (Guid guidDev)
		{
			this.guid = guidDev;
		}

		public Device ()
		{

		}

		public void Dispose ()
		{
			throw new NotImplementedException ();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public IntPtr GetObjectByValue (int objId)
		{
			throw new NotImplementedException ();
		}

		public void SetCooperativeLevel (IntPtr owner, CooperativeLevel level)
		{
			throw new NotImplementedException ();
		}

		public void SetCooperativeLevel (Control owner, CooperativeLevel level)
		{

		}

		public void Compact ()
		{
			throw new NotImplementedException ();
		}
	}
}

