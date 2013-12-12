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
	public struct Vector3
	{
		public float X;
		public float Y;
		public float Z;

		public static Vector3 Empty {
			get {
				return new Vector3(0.0f, 0.0f, 0.0f);
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
		
		public static bool operator == (Vector3 left, Vector3 right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (Vector3 left, Vector3 right)
		{
			throw new NotImplementedException ();
		}

		public Vector3 (float valueX, float valueY, float valueZ)
		{
			this.X = valueX;
			this.Y = valueY;
			this.Z = valueZ;
		}

		public override string ToString ()
		{
			throw new NotImplementedException ();
		}

		public static Vector3 operator - (Vector3 vec)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 operator + (Vector3 left, Vector3 right)
		{
			throw new NotImplementedException (); 
		}

		public static Vector3 operator - (Vector3 left, Vector3 right)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 operator * (float right, Vector3 left)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 operator * (Vector3 left, float right)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 Multiply (Vector3 source, float f)
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

		public static float Length (Vector3 source)
		{
			throw new NotImplementedException ();
		}

		public float LengthSq ()
		{
			throw new NotImplementedException ();
		}

		public static float LengthSq (Vector3 source)
		{
			throw new NotImplementedException ();
		}

		public static float Dot (Vector3 left, Vector3 right)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 Cross (Vector3 left, Vector3 right)
		{
			throw new NotImplementedException ();
		}

		public void Add (Vector3 source)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 Add (Vector3 left, Vector3 right)
		{
			throw new NotImplementedException ();
		}

		public void Subtract (Vector3 source)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 Subtract (Vector3 left, Vector3 right)
		{
			throw new NotImplementedException ();
		}

		public void Minimize (Vector3 source)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 Minimize (Vector3 left, Vector3 right)
		{
			throw new NotImplementedException ();
		}

		public void Maximize (Vector3 source)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 Maximize (Vector3 left, Vector3 right)
		{
			throw new NotImplementedException ();
		}

		public void Scale (float scalingFactor)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 Scale (Vector3 source, float scalingFactor)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 Lerp (Vector3 left, Vector3 right, float interpolater)
		{
			throw new NotImplementedException ();
		}

		public void Normalize ()
		{
			throw new NotImplementedException ();
		}

		public static Vector3 Normalize (Vector3 source)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 Hermite (Vector3 position, Vector3 tangent, Vector3 position2, Vector3 tangent2, float weightingFactor)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 CatmullRom (Vector3 position1, Vector3 position2, Vector3 position3, Vector3 position4, float weightingFactor)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 BaryCentric (Vector3 v1, Vector3 v2, Vector3 v3, float f, float g)
		{
			throw new NotImplementedException ();
		}

		public static Vector4[] Transform (Vector3[] vector, Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}

		public static Vector4 Transform (Vector3 source, Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}

		public void TransformCoordinate (Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}

		public static Vector3[] TransformCoordinate (Vector3[] vector, Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 TransformCoordinate (Vector3 source, Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}

		public void TransformNormal (Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}

		public static Vector3[] TransformNormal (Vector3[] vector, Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 TransformNormal (Vector3 source, Matrix sourceMatrix)
		{
			throw new NotImplementedException ();
		}

		public void Project (object viewport, Matrix projection, Matrix view, Matrix world)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 Project (Vector3 v, object viewport, Matrix projection, Matrix view, Matrix world)
		{
			throw new NotImplementedException ();
		}

		public void Unproject (object viewport, Matrix projection, Matrix view, Matrix world)
		{
			throw new NotImplementedException ();
		}

		public static Vector3 Unproject (Vector3 v, object viewport, Matrix projection, Matrix view, Matrix world)
		{
			throw new NotImplementedException ();
		}
	}
}


