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
	public struct Quaternion
	{
		public float X;
		public float Y;
		public float Z;
		public float W;

		public static Quaternion Identity {
			get {
				Quaternion quat = new Quaternion();
				quat.X = 0.0f;
				quat.Y = 0.0f;
				quat.Z = 0.0f;
				quat.W = 1.0f;
				
				return quat;
			}
		}

		public static Quaternion Zero {
			get {
				throw new NotImplementedException ();
			}
		}
		
		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator == (Quaternion left, Quaternion right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (Quaternion left, Quaternion right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}

		public Quaternion (float valueX, float valueY, float valueZ, float valueW)
		{
			throw new NotImplementedException ();
		}

		public override string ToString ()
		{
			throw new NotImplementedException ();
		}

		public static Quaternion operator + (Quaternion left, Quaternion right)
		{
			throw new NotImplementedException ();
		}

		public static Quaternion operator * (Quaternion left, Quaternion right)
		{
			throw new NotImplementedException ();
		}

		public static Quaternion operator - (Quaternion left, Quaternion right)
		{
			throw new NotImplementedException ();
		}

		public static Quaternion Add (Quaternion m1, Quaternion m2)
		{
			throw new NotImplementedException ();
		}

		public static Quaternion Subtract (Quaternion m1, Quaternion m2)
		{
			throw new NotImplementedException ();
		}

		public float Length ()
		{
			throw new NotImplementedException ();
		}

		public static float Length (Quaternion v)
		{
			throw new NotImplementedException ();
		}

		public float LengthSq ()
		{
			throw new NotImplementedException ();
		}

		public static float LengthSq (Quaternion v)
		{
			throw new NotImplementedException ();
		}

		public static float Dot (Quaternion v1, Quaternion v2)
		{
			throw new NotImplementedException ();
		}

		public static Quaternion Conjugate (Quaternion q)
		{
			throw new NotImplementedException ();
		}

		public static void ToAxisAngle (Quaternion q, ref Vector3 axis, ref float angle)
		{
			throw new NotImplementedException ();
		}

		public static Quaternion RotationMatrix (Matrix m)
		{
			throw new NotImplementedException ();
		}

		public static Quaternion RotationAxis (Vector3 v, float angle)
		{
			throw new NotImplementedException ();
		}

		public static Quaternion RotationYawPitchRoll (float yaw, float pitch, float roll)
		{
			throw new NotImplementedException ();
		}

		public void Multiply (Quaternion q)
		{
			throw new NotImplementedException ();
		}

		public static Quaternion Multiply (Quaternion m1, Quaternion m2)
		{
			throw new NotImplementedException ();
		}

		public void Normalize ()
		{
			throw new NotImplementedException ();
		}

		public static Quaternion Normalize (Quaternion q)
		{
			throw new NotImplementedException ();
		}

		public void Invert ()
		{
			throw new NotImplementedException ();
		}

		public static Quaternion Invert (Quaternion q)
		{
			throw new NotImplementedException ();
		}

		public void Ln ()
		{
			throw new NotImplementedException ();
		}

		public static Quaternion Ln (Quaternion q)
		{
			throw new NotImplementedException ();
		}

		public void Exp ()
		{
			throw new NotImplementedException ();
		}

		public static Quaternion Exp (Quaternion q)
		{
			throw new NotImplementedException ();
		}

		public static Quaternion Slerp (Quaternion q1, Quaternion q2, float t)
		{
			throw new NotImplementedException ();
		}

		public static Quaternion Squad (Quaternion q1, Quaternion a, Quaternion b, Quaternion c, float t)
		{
			throw new NotImplementedException ();
		}

		public static Quaternion BaryCentric (Quaternion q1, Quaternion q2, Quaternion q3, float f, float g)
		{
			throw new NotImplementedException ();
		}

		public static void SquadSetup (ref Quaternion outA, ref Quaternion outB, ref Quaternion outC, Quaternion q0, Quaternion q1, Quaternion q2, Quaternion q3)
		{
			throw new NotImplementedException ();
		}

		public void RotateMatrix (Matrix m)
		{
			throw new NotImplementedException ();
		}

		public void RotateAxis (Vector3 v, float angle)
		{
			throw new NotImplementedException ();
		}

		public void RotateYawPitchRoll (float yaw, float pitch, float roll)
		{
			throw new NotImplementedException ();
		}
	}
}

