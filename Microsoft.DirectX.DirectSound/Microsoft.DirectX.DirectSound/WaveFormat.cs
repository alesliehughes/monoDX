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
using Microsoft.VisualC;

namespace Microsoft.DirectX.DirectSound
{
	[MiscellaneousBits(1)]
	public struct WaveFormat
	{
		private short mBitPerSample;
		private short mBlockAlign;
		private int mAvgPerSec;
		private int mSamplePrSec;
		private short mChannels;
		private short mFormatTag;

		public short BitsPerSample {
			get {
				return mBitPerSample;
			}
			set {
				mBitPerSample = value;
			}
		}

		public short BlockAlign {
			get {
				return mBlockAlign;
			}
			set {
				mBlockAlign = value;
			}
		}

		public int AverageBytesPerSecond {
			get {
				return mAvgPerSec;
			}
			set {
				mAvgPerSec = value;
			}
		}

		public int SamplesPerSecond {
			get {
				return mSamplePrSec;
			}
			set {
				mSamplePrSec = value;
			}
		}

		public short Channels {
			get {
				return mChannels;
			}
			set {
				mChannels = value;
			}
		}

		public WaveFormatTag FormatTag {
			get {
				return (WaveFormatTag)mFormatTag;
			}
			set {
				this.mFormatTag = (short)value;
			}
		}

		public override string ToString ()
		{
			throw new NotImplementedException ();
		}
	}
}

