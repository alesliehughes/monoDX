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
	public struct Vector2
	{
		public float X;
		public float Y;

		public static Vector2 Empty {
			get {
				return new Vector2 (0.0f, 0.0f);
			}
		}
		
		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator == (Vector2 left, Vector2 right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (Vector2 left, Vector2 right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}

		public Vector2 (float valueX, float valueY)
		{
			X = valueX;
			Y = valueY;
		}

		public override string ToString ()
		{
			throw new NotImplementedException ();
		}

		public static Vector2 operator - (Vector2 vec)
		{
			throw new NotImplementedException ();
		}

		public static Vector2 operator + (Vector2 left, Vector2 right)
		{
			throw new NotImplementedException ();
		}

		public static Vector2 operator - (Vector2 left, Vector2 right)
		{
			throw new NotImplementedException ();
		}

		public static Vector2 operator * (float right, Vector2 left)
		{
			throw new NotImplementedException ();
		}

		public static Vector2 operator * (Vector2 left, float right)
		{
			throw new NotImplementedException ();
		}

		public static Vector2 Multiply (Vector2 source, float s)
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

		public static float Length (Vector2 source)
		{
			throw new NotImplementedException ();
		}

		public float LengthSq ()
		{
			throw new NotImplementedException ();
		}

		public static float LengthSq (Vector2 source)
		{
			throw new NotImplementedException ();
		}

		public static float Dot (Vector2 left, Vector2 right)
		{
			throw new NotImplementedException ();
		}

		public static float Ccw (Vector2 left, Vector2 right)
		{
			throw new NotImplementedException ();
		}

		public void Add (Vector2 v)
		{
			throw new NotImplementedException ();
		}

		public static Vector2 Add (Vector2 left, Vector2 right)
		{
			throw new NotImplementedException ();
		}

		public void Subtract (Vector2 source)
		{
			throw new NotImplementedException ();
		}

		public static Vector2 Subtract (Vector2 left, Vector2 right)
		{
			throw new NotImplementedException ();
		}

		public void Minimize (Vector2 source)
		{
			throw new NotImplementedException ();
		}

		public static Vector2 Minimize (Vector2 left, Vector2 right)
		{
			throw new NotImplementedException ();
		}

		public void Maximize (Vector2 source)
		{
			throw new NotImplementedException ();
		}

		public static Vector2 Maximize (Vector2 left, Vector2 right)
		{
			throw new NotImplementedException ();
		}

		public void Scale (float scalingFactor)
		{
			throw new NotImplementedException ();
		}

		public static Vector2 Scale (Vector2 source, float scalingFactor)
		{
			throw new NotImplementedException ();
		}

		public static Vector2 Lerp (Vector2 left, Vector2 right, float interpolater)
		{
			throw new NotImplementedException ();
		}

		public void Normalize ()
		{
			throw new NotImplementedException ();
		}

		public static Vector2 Normalize (Vector2 source)
		{
			throw new NotImplementedException ();
		}

		public static Vector2 Hermite (Vector2 position, Vector2 tangent, Vector2 position2, Vector2 tangent2, float weightingFactor)
		{
			throw new NotImplementedException ();
		}

		public static Vector2 CatmullRom (Vector2 position1, Vector2 position2, Vector2 position3, Vector2 position4, float weightingFactor)
		{
			throw new NotImplementedException ();
		}

		public static Vector2 BaryCentric (Vector2 v1, Vector2 v2, Vector2 v3, float f, float g)
		{
			throw new NotImplementedException ();
		}

		public static Vector4[] Transform (Vector2[] vector, Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}

		public static Vector4 Transform (Vector2 source, Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}

		public void TransformCoordinate (Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}

		public static Vector2[] TransformCoordinate (Vector2[] vector, Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}

		public static Vector2 TransformCoordinate (Vector2 source, Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}

		public void TransformNormal (Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}

		public static Vector2[] TransformNormal (Vector2[] vector, Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}

		public static Vector2 TransformNormal (Vector2 source, Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}
	}
}

