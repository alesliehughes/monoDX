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
using System.IO;

namespace Microsoft.DirectX.DirectSound
{
	public class CaptureBuffer
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

		public bool Capturing {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public bool Looping {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public WaveFormat Format {
			get {
				throw new NotImplementedException ();
			}
		}

		public CaptureBufferCaps Caps {
			get {
				throw new NotImplementedException ();
			}
		}
		
		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator == (CaptureBuffer left, CaptureBuffer right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (CaptureBuffer left, CaptureBuffer right)
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

		[EditorBrowsable(EditorBrowsableState.Never)]
		public IntPtr GetObjectByValue (int objId)
		{
			throw new NotImplementedException ();
		}

		public CaptureBuffer (IntPtr lp, Capture device)
		{
			throw new NotImplementedException ();
		}

		public CaptureBuffer (CaptureBufferDescription desc, Capture parent)
		{
			throw new NotImplementedException ();
		}

		public void GetCurrentPosition (out int currentCapturePosition, out int currentReadPosition)
		{
			throw new NotImplementedException ();
		}

		public void Stop ()
		{
			throw new NotImplementedException ();
		}

		public void Start (bool looping)
		{
			throw new NotImplementedException ();
		}

		public Array Read (int bufferStartingLocation, Type returnedDataType, LockFlag flag, params int[] ranks)
		{
			throw new NotImplementedException ();
		}

		public void Read (int bufferStartingLocation, Stream data, int numberBytesToRead, LockFlag flag)
		{
			throw new NotImplementedException ();
		}

		public void Write (int bufferStartingLocation, Array data, LockFlag flag)
		{
			throw new NotImplementedException ();
		}

		public void Write (int bufferStartingLocation, Stream data, int numberBytesToWrite, LockFlag flag)
		{
			throw new NotImplementedException ();
		}

		public object GetObjectInPath (Guid guidObject, int index, Guid guidInterface)
		{
			throw new NotImplementedException ();
		}

		public CaptureEffectsReturnValue[] GetEffectsStatus (int numEffects)
		{
			throw new NotImplementedException ();
		}
	}
}

