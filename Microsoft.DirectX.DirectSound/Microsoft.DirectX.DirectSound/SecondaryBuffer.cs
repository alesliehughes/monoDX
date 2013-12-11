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
using System.IO;
using System.ComponentModel;

namespace Microsoft.DirectX.DirectSound
{
	public class SecondaryBuffer : Buffer
	{
		public new event EventHandler Disposing {
			add {
				throw new NotImplementedException ();
			}

			remove {
				throw new NotImplementedException ();
			}
		}

		public new bool Disposed {
			
			get {
				throw new NotImplementedException ();
			}
		}
		
		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator == (SecondaryBuffer left, SecondaryBuffer right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (SecondaryBuffer left, SecondaryBuffer right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public new IntPtr GetObjectByValue (int objId)
		{
			throw new NotImplementedException ();
		}

		public SecondaryBuffer (Stream source, int length, Device parent) : base(source, length, parent)
		{
			throw new NotImplementedException ();
		}

		public SecondaryBuffer (Stream source, Device parent) : base(source, parent)
		{
			throw new NotImplementedException ();
		}

		public SecondaryBuffer (string fileName, Device parent) : base(fileName, parent)
		{
			throw new NotImplementedException ();
		}

		public SecondaryBuffer (Stream source, int length, BufferDescription desc, Device parent) : base(source, length, desc, parent)
		{
			throw new NotImplementedException ();
		}

		public SecondaryBuffer (Stream source, BufferDescription desc, Device parent) : base(source, desc, parent)
		{
			throw new NotImplementedException ();
		}

		public SecondaryBuffer (string fileName, BufferDescription desc, Device parent) : base(fileName, desc, parent)
		{
			throw new NotImplementedException ();
		}

		public SecondaryBuffer (BufferDescription desc, Device parent) : base(desc, parent)
		{
			throw new NotImplementedException ();
		}

		public EffectsReturnValue[] AcquireResources (int flags, int effectsCount)
		{
			throw new NotImplementedException ();
		}

		public EffectsReturnValue[] SetEffects (EffectDescription[] dsEff)
		{
			throw new NotImplementedException ();
		}

		public object GetObjectInPath (Guid guidObject, int index, Guid guidInterface)
		{
			throw new NotImplementedException ();
		}

		public object[] GetEffects (int startIndex, int count)
		{
			throw new NotImplementedException ();
		}

		public object GetEffects (int index)
		{
			throw new NotImplementedException ();
		}

		public new void Dispose ()
		{
			throw new NotImplementedException ();
		}

		public new SecondaryBuffer Clone (Device parent)
		{
			throw new NotImplementedException ();
		}
	}
}

