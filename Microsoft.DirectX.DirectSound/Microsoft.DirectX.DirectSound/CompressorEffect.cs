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

namespace Microsoft.DirectX.DirectSound
{
	public class CompressorEffect : MarshalByRefObject, IDisposable
	{
		public static readonly float GainMin;
		public static readonly float GainMax;
		public static readonly float AttackMin;
		public static readonly float AttackMax;
		public static readonly float ReleaseMin;
		public static readonly float ReleaseMax;
		public static readonly float ThresholdMin;
		public static readonly float ThresholdMax;
		public static readonly float RatioMin;
		public static readonly float RatioMax;
		public static readonly float PreDelayMin;
		public static readonly float PreDelayMax;

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

		public EffectsCompressor AllParameters {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}
		
		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}

		public static bool operator == (CompressorEffect left, CompressorEffect right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (CompressorEffect left, CompressorEffect right)
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

		public CompressorEffect (IntPtr lp, SecondaryBuffer source)
		{
			throw new NotImplementedException ();
		}

		static CompressorEffect ()
		{
			throw new NotImplementedException ();
		}

	}
}

