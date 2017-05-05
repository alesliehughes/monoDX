/*
 * The MIT License (MIT)
 *
 * Copyright (c) 2017 Alistair Leslie-Hughes
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
using System.Drawing;
using Microsoft.VisualC;

namespace Microsoft.DirectX.Direct3D
{
	[MiscellaneousBits(1)]
	public struct ColorValue
	{
		float mRed;
		float mGreen;
		float mBlue;
		float mAlpha;

		public float Alpha {
			get {
				return mAlpha;
			}
			set {
				mAlpha = value;
			}
		}

		public float Green {
			get {
				return mGreen;
			}
			set {
				mGreen = value;
			}
		}

		public float Blue {
			get {
				return mBlue;
			}
			set {
				mBlue = value;
			}
		}

		public float Red {
			get {
				return mRed;
			}
			set {
				mRed = value;
			}
		}

		public ColorValue (int r, int g, int b)
		{
			mRed = r;
			mGreen = g;
			mBlue = b;
			mAlpha = 0.0f;
		}

		public ColorValue (int r, int g, int b, int a)
		{
			mRed = r;
			mGreen = g;
			mBlue = b;
			mAlpha = a;
		}

		public ColorValue (float r, float g, float b)
		{
			mRed = r;
			mGreen = g;
			mBlue = b;
			mAlpha = 0.0f;
		}

		public ColorValue (float r, float g, float b, float a)
		{
			mRed = r;
			mGreen = g;
			mBlue = b;
			mAlpha = a;
		}

		public int ToArgb ()
		{
			throw new NotImplementedException ();
		}

		public static ColorValue FromArgb (int color)
		{
			throw new NotImplementedException ();

		}

		public static ColorValue FromColor (Color color)
		{
			throw new NotImplementedException ();
		}
	}
}
