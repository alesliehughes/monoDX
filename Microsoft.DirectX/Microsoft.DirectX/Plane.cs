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

namespace Microsoft.DirectX
{
	[Serializable]
	public struct Plane
	{
		public float A;
		public float B;
		public float C;
		public float D;

		public static Plane Empty {
			get {
				throw new NotImplementedException ();
			}
		}
		
		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator == (Plane left, Plane right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (Plane left, Plane right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}

		public Plane (float valuePointA, float valuePointB, float valuePointC, float valuePointD)
		{
			throw new NotImplementedException ();
		}

		public override string ToString ()
		{
			throw new NotImplementedException ();
		}

		public static float DotNormal (Plane p, Vector3 v)
		{
			throw new NotImplementedException ();
		}

		public void Normalize ()
		{
			throw new NotImplementedException ();
		}

		public static Plane Normalize (Plane p)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 IntersectLine (Plane p, Vector3 v1, Vector3 v2)
		{
			throw new NotImplementedException ();
		}

		public static Plane FromPointNormal (Vector3 point, Vector3 normal)
		{
			throw new NotImplementedException ();
		}

		public static Plane FromPoints (Vector3 p1, Vector3 p2, Vector3 p3)
		{
			throw new NotImplementedException ();
		}

		public void Transform (Matrix m)
		{
			throw new NotImplementedException ();
		}

		public static Plane Transform (Plane p, Matrix m)
		{
			throw new NotImplementedException ();
		}

		public void Scale (float s)
		{
			throw new NotImplementedException ();
		}

		public static Plane Scale (Plane p, float s)
		{
			throw new NotImplementedException ();
		}

		public float Dot (Vector3 v)
		{
			throw new NotImplementedException ();
		}

		public float Dot (Vector4 v)
		{
			throw new NotImplementedException ();
		}
	}
}

