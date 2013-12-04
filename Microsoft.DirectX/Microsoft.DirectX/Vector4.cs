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
	public struct Vector4
	{
		public static Vector4 Empty {
			get {
				throw new NotImplementedException ();
			}
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}
		
		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator == (Vector4 left, Vector4 right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (Vector4 left, Vector4 right)
		{
			throw new NotImplementedException ();
		}

		public Vector4 (float valueX, float valueY, float valueZ, float valueW)
		{
			throw new NotImplementedException ();
		}

		public override string ToString ()
		{
			throw new NotImplementedException ();
		}

		public static Vector4 operator - (Vector4 vec)
		{
			throw new NotImplementedException ();
		}

		public static Vector4 operator + (Vector4 left, Vector4 right)
		{
			throw new NotImplementedException ();
		}

		public static Vector4 operator - (Vector4 left, Vector4 right)
		{
			throw new NotImplementedException ();
		}

		public static Vector4 operator * (float right, Vector4 left)
		{
			throw new NotImplementedException ();
		}

		public static Vector4 operator * (Vector4 left, float right)
		{
			throw new NotImplementedException ();
		}

		public static Vector4 Multiply (Vector4 source, float f)
		{
			throw new NotImplementedException ();
		}

		public void Multiply (float s)
		{
			throw new NotImplementedException ();
		}

		public float Length ()
		{
			throw new NotImplementedException ();
		}

		public static float Length (Vector4 source)
		{
			throw new NotImplementedException ();
		}

		public float LengthSq ()
		{
			throw new NotImplementedException ();
		}

		public static float LengthSq (Vector4 source)
		{
			throw new NotImplementedException ();
		}

		public static float Dot (Vector4 left, Vector4 right)
		{
			throw new NotImplementedException ();
		}

		public static Vector4 Cross (Vector4 v1, Vector4 v2, Vector4 v3)
		{
			throw new NotImplementedException ();
		}

		public void Add (Vector4 source)
		{
			throw new NotImplementedException ();
		}

		public static Vector4 Add (Vector4 left, Vector4 right)
		{
			throw new NotImplementedException ();
		}

		public void Subtract (Vector4 source)
		{
			throw new NotImplementedException ();
		}

		public static Vector4 Subtract (Vector4 left, Vector4 right)
		{
			throw new NotImplementedException ();
		}

		public void Minimize (Vector4 source)
		{
			throw new NotImplementedException ();
		}

		public static Vector4 Minimize (Vector4 left, Vector4 right)
		{
			throw new NotImplementedException ();
		}

		public void Maximize (Vector4 source)
		{
			throw new NotImplementedException ();
		}

		public static Vector4 Maximize (Vector4 left, Vector4 right)
		{
			throw new NotImplementedException ();
		}

		public void Scale (float scalingFactor)
		{
			throw new NotImplementedException ();
		}

		public static Vector4 Scale (Vector4 source, float scalingFactor)
		{
			throw new NotImplementedException ();
		}

		public static Vector4 Lerp (Vector4 left, Vector4 right, float interpolater)
		{
			throw new NotImplementedException ();
		}

		public void Normalize ()
		{
			throw new NotImplementedException ();
		}

		public static Vector4 Normalize (Vector4 source)
		{
			throw new NotImplementedException ();
		}

		public static Vector4 Hermite (Vector4 position, Vector4 tangent, Vector4 position2, Vector4 tangent2, float weightingFactor)
		{
			throw new NotImplementedException ();
		}

		public static Vector4 CatmullRom (Vector4 position1, Vector4 position2, Vector4 position3, Vector4 position4, float weightingFactor)
		{
			throw new NotImplementedException ();
		}

		public static Vector4 BaryCentric (Vector4 v1, Vector4 v2, Vector4 v3, float f, float g)
		{
			throw new NotImplementedException ();
		}

		public void Transform (Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}

		public static Vector4[] Transform (Vector4[] vector, Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}

		public static Vector4 Transform (Vector4 source, Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}
	}
}

