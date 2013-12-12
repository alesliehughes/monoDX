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
	public struct Matrix
	{
		public float M11;
		public float M12;
		public float M13;
		public float M14;
		public float M21;
		public float M22;
		public float M23;
		public float M24;
		public float M31;
		public float M32;
		public float M33;
		public float M34;
		public float M41;
		public float M42;
		public float M43;
		public float M44;
		
		public float Determinant {
			get {
				throw new NotImplementedException ();
			}
		}

		public static Matrix Identity {
			get {
				Matrix mat = new Matrix();
				mat.M11 = mat.M22 = mat.M33 = mat.M44 = 1.0f;

				return mat;
			}
		}

		public static Matrix Zero {
			get {
				throw new NotImplementedException ();
			}
		}

		public override string ToString ()
		{
			throw new NotImplementedException ();
		}
		
		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator == (Matrix left, Matrix right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (Matrix left, Matrix right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}

		public static Matrix operator + (Matrix left, Matrix right)
		{
			throw new NotImplementedException ();
		}

		public static Matrix operator - (Matrix left, Matrix right)
		{
			throw new NotImplementedException ();
		}

		public static Matrix operator * (Matrix left, Matrix right)
		{
			throw new NotImplementedException ();
		}

		public static Matrix Add (Matrix left, Matrix right)
		{
			throw new NotImplementedException ();
		}

		public static Matrix Subtract (Matrix left, Matrix right)
		{
			throw new NotImplementedException ();
		}

		public void Multiply (Matrix source)
		{
			throw new NotImplementedException ();
		}

		public static Matrix Multiply (Matrix left, Matrix right)
		{
			throw new NotImplementedException ();
		}

		public void MultiplyTranspose (Matrix source)
		{
			throw new NotImplementedException ();
		}

		public static Matrix MultiplyTranspose (Matrix left, Matrix right)
		{
			throw new NotImplementedException ();
		}

		public void Invert ()
		{
			throw new NotImplementedException ();
		}

		public static Matrix Invert (Matrix source)
		{
			throw new NotImplementedException ();
		}

		public static Matrix Invert (ref float determinant, Matrix source)
		{
			throw new NotImplementedException ();
		}

		public static Matrix Scaling (Vector3 v)
		{
			throw new NotImplementedException ();
		}

		public static Matrix Scaling (float x, float y, float z)
		{
			throw new NotImplementedException ();
		}

		public static Matrix Translation (Vector3 v)
		{
			throw new NotImplementedException ();
		}

		public static Matrix Translation (float x, float y, float z)
		{
			throw new NotImplementedException ();
		}

		public static Matrix RotationX (float angle)
		{
			throw new NotImplementedException ();
		}

		public static Matrix RotationY (float angle)
		{
			throw new NotImplementedException ();
		}

		public static Matrix RotationZ (float angle)
		{
			throw new NotImplementedException ();
		}

		public static Matrix RotationAxis (Vector3 axisRotation, float angle)
		{
			throw new NotImplementedException ();
		}

		public static Matrix RotationQuaternion (Quaternion quat)
		{
			throw new NotImplementedException ();
		}

		public static Matrix RotationYawPitchRoll (float yaw, float pitch, float roll)
		{
			throw new NotImplementedException ();
		}

		public static Matrix Transformation (Vector3 scalingCenter, Quaternion scalingRotation, Vector3 scalingFactor, Vector3 rotationCenter, Quaternion rotation, Vector3 translation)
		{
			throw new NotImplementedException ();
		}

		public static Matrix LookAtRH (Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector)
		{
			throw new NotImplementedException ();
		}

		public static Matrix LookAtLH (Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector)
		{
			throw new NotImplementedException ();
		}

		public static Matrix PerspectiveRH (float width, float height, float znearPlane, float zfarPlane)
		{
			throw new NotImplementedException ();
		}

		public static Matrix PerspectiveLH (float width, float height, float znearPlane, float zfarPlane)
		{
			throw new NotImplementedException ();
		}

		public static Matrix PerspectiveFovRH (float fieldOfViewY, float aspectRatio, float znearPlane, float zfarPlane)
		{
			throw new NotImplementedException ();
		}

		public static Matrix PerspectiveFovLH (float fieldOfViewY, float aspectRatio, float znearPlane, float zfarPlane)
		{
			throw new NotImplementedException ();
		}

		public static Matrix PerspectiveOffCenterRH (float left, float right, float bottom, float top, float znearPlane, float zfarPlane)
		{
			throw new NotImplementedException ();
		}

		public static Matrix PerspectiveOffCenterLH (float left, float right, float bottom, float top, float znearPlane, float zfarPlane)
		{
			throw new NotImplementedException ();
		}

		public static Matrix OrthoRH (float width, float height, float znearPlane, float zfarPlane)
		{
			throw new NotImplementedException ();
		}

		public static Matrix OrthoLH (float width, float height, float znearPlane, float zfarPlane)
		{
			throw new NotImplementedException ();
		}

		public static Matrix OrthoOffCenterRH (float left, float right, float bottom, float top, float znearPlane, float zfarPlane)
		{
			throw new NotImplementedException ();
		}

		public static Matrix OrthoOffCenterLH (float left, float right, float bottom, float top, float znearPlane, float zfarPlane)
		{
			throw new NotImplementedException ();
		}

		public static Matrix Transformation2D (Vector2 scalingCenter, float scalingRotation, Vector2 scaling, Vector2 rotationCenter, float rotation, Vector2 translation)
		{
			throw new NotImplementedException ();
		}

		public static Matrix AffineTransformation2D (float scaling, Vector2 rotationCenter, float rotation, Vector2 translation)
		{
			throw new NotImplementedException ();
		}

		public static Matrix TransposeMatrix (Matrix source)
		{
			throw new NotImplementedException ();
		}

		public void Transpose (Matrix source)
		{
			throw new NotImplementedException ();
		}

		public void Scale (Vector3 v)
		{
			throw new NotImplementedException ();
		}

		public void Scale (float x, float y, float z)
		{
			throw new NotImplementedException ();
		}

		public void Translate (Vector3 v)
		{
			throw new NotImplementedException ();
		}

		public void Translate (float x, float y, float z)
		{
			throw new NotImplementedException ();
		}

		public void RotateX (float angle)
		{
			throw new NotImplementedException ();
		}

		public void RotateY (float angle)
		{
			throw new NotImplementedException ();
		}

		public void RotateZ (float angle)
		{
			throw new NotImplementedException ();
		}

		public void RotateAxis (Vector3 axisRotation, float angle)
		{
			throw new NotImplementedException ();
		}

		public void RotateQuaternion (Quaternion quat)
		{
			throw new NotImplementedException ();
		}

		public void RotateYawPitchRoll (float yaw, float pitch, float roll)
		{
			throw new NotImplementedException ();
		}

		public void Transform (Vector3 scalingCenter, Quaternion scalingRotation, Vector3 scalingFactor, Vector3 rotationCenter, Quaternion rotation, Vector3 translation)
		{
			throw new NotImplementedException ();
		}

		public void AffineTransformation (float scaling, Vector3 rotationCenter, Quaternion rotation, Vector3 translation)
		{
			throw new NotImplementedException ();
		}

		public void Shadow (Vector4 light, Plane plane)
		{
			throw new NotImplementedException ();
		}

		public void Reflect (Plane plane)
		{
			throw new NotImplementedException ();
		}
	}
}


