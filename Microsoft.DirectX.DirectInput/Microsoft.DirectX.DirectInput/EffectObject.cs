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

namespace Microsoft.DirectX.DirectInput
{
	public class EffectObject : MarshalByRefObject, IDisposable
	{
		public Guid EffectGuid {
			get {
				throw new NotImplementedException ();
			}
		}

		public EffectStatus EffectStatus {
			get {
				throw new NotImplementedException ();
			}
		}

		public EffectObject (Guid eff, Effect die, Device dev)
		{
			throw new NotImplementedException ();
		}

		public EffectObject (Guid eff, Device dev)
		{
			throw new NotImplementedException ();
		}

		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}

		public static bool operator == (EffectObject left, EffectObject right)
		{
			throw new NotImplementedException ();
		}

		public static bool operator != (EffectObject left, EffectObject right)
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

		public void Download ()
		{
			throw new NotImplementedException ();
		}

		public byte[] SendHardwareCommand (int command, byte[] data)
		{
			throw new NotImplementedException ();
		}

		public void GetParameters (ref Effect eff, EffectParameterFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void SetParameters (Effect eff, EffectParameterFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void Start (int iterations)
		{
			throw new NotImplementedException ();
		}

		public void Start (int iterations, EffectStartFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void Stop ()
		{
			throw new NotImplementedException ();
		}

		public void Unload ()
		{
			throw new NotImplementedException ();
		}

	}
}

