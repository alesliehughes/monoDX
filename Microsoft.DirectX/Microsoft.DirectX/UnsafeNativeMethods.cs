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
	public sealed class UnsafeNativeMethods
	{
		public sealed class Matrix
		{
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Matrix* Multiply(Microsoft.DirectX.Matrix* pOut, Microsoft.DirectX.Matrix* left, Microsoft.DirectX.Matrix* right)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Matrix* MultiplyTranspose(Microsoft.DirectX.Matrix* pOut, Microsoft.DirectX.Matrix* left, Microsoft.DirectX.Matrix* right)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Matrix* Invert(Microsoft.DirectX.Matrix* pOut, Microsoft.DirectX.Matrix* source)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Matrix* Invert(Microsoft.DirectX.Matrix* pOut, float* determinant, Microsoft.DirectX.Matrix* source)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Matrix* Scaling(Microsoft.DirectX.Matrix* pOut, Microsoft.DirectX.Vector3* v)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Matrix* Translation(Microsoft.DirectX.Matrix* pOut, Microsoft.DirectX.Vector3* v)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Matrix* RotationAxis(Microsoft.DirectX.Matrix* pOut, Microsoft.DirectX.Vector3* axisRotation, float angle)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Matrix* RotationQuaternion(Microsoft.DirectX.Matrix* pOut, Microsoft.DirectX.Quaternion* quat)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Matrix* Transformation(Microsoft.DirectX.Matrix* pOut, Microsoft.DirectX.Vector3* scalingCenter, Microsoft.DirectX.Quaternion* scalingRotation, Microsoft.DirectX.Vector3* scalingFactor, Microsoft.DirectX.Vector3* rotationCenter, Microsoft.DirectX.Quaternion* rotation, Microsoft.DirectX.Vector3* translation)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Matrix* LookAtRH(Microsoft.DirectX.Matrix* pOut, Microsoft.DirectX.Vector3* cameraPosition, Microsoft.DirectX.Vector3* cameraTarget, Microsoft.DirectX.Vector3* cameraUpVector)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Matrix* LookAtLH(Microsoft.DirectX.Matrix* pOut, Microsoft.DirectX.Vector3* cameraPosition, Microsoft.DirectX.Vector3* cameraTarget, Microsoft.DirectX.Vector3* cameraUpVector)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Matrix* Transformation2D(Microsoft.DirectX.Matrix* pOut, Microsoft.DirectX.Vector2* scalingCenter, float scalingRotation, Microsoft.DirectX.Vector2* scaling, Microsoft.DirectX.Vector2* rotationCenter, float rotation, Microsoft.DirectX.Vector2* translation)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Matrix* AffineTransformation2D(Microsoft.DirectX.Matrix* pOut, float scaling, Microsoft.DirectX.Vector2* rotationCenter, float rotation, Microsoft.DirectX.Vector2* translation)
			{
				throw new NotImplementedException ();
			}
		}
		public sealed class Vector4
		{
			[CLSCompliant(false)]
			public unsafe static float Length(Microsoft.DirectX.Vector4* pSource)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static float LengthSq(Microsoft.DirectX.Vector4* pSource)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static float Dot(Microsoft.DirectX.Vector4* pLeft, Microsoft.DirectX.Vector4* pRight)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector4* Cross(Microsoft.DirectX.Vector4* pOut, Microsoft.DirectX.Vector4* pV1, Microsoft.DirectX.Vector4* pV2, Microsoft.DirectX.Vector4* pV3)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector4* Add(Microsoft.DirectX.Vector4* pOut, Microsoft.DirectX.Vector4* pLeft, Microsoft.DirectX.Vector4* pRight)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector4* Subtract(Microsoft.DirectX.Vector4* pOut, Microsoft.DirectX.Vector4* pLeft, Microsoft.DirectX.Vector4* pRight)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector4* Minimize(Microsoft.DirectX.Vector4* pOut, Microsoft.DirectX.Vector4* pLeft, Microsoft.DirectX.Vector4* pRight)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector4* Maximize(Microsoft.DirectX.Vector4* pOut, Microsoft.DirectX.Vector4* pLeft, Microsoft.DirectX.Vector4* pRight)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector4* Scale(Microsoft.DirectX.Vector4* pOut, Microsoft.DirectX.Vector4* pSource, float scalingFactor)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector4* Lerp(Microsoft.DirectX.Vector4* pOut, Microsoft.DirectX.Vector4* pLeft, Microsoft.DirectX.Vector4* pRight, float interpolater)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector4* Normalize(Microsoft.DirectX.Vector4* pOut, Microsoft.DirectX.Vector4* pSource)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector4* Hermite(Microsoft.DirectX.Vector4* pOut, Microsoft.DirectX.Vector4* pPosition, Microsoft.DirectX.Vector4* pTangent, Microsoft.DirectX.Vector4* pPosition2, Microsoft.DirectX.Vector4* pTangent2, float weightingFactor)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector4* CatmullRom(Microsoft.DirectX.Vector4* pOut, Microsoft.DirectX.Vector4* pPosition1, Microsoft.DirectX.Vector4* pPosition2, Microsoft.DirectX.Vector4* pPosition3, Microsoft.DirectX.Vector4* pPosition4, float weightingFactor)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector4* BaryCentric(Microsoft.DirectX.Vector4* pOut, Microsoft.DirectX.Vector4* pV1, Microsoft.DirectX.Vector4* pV2, Microsoft.DirectX.Vector4* pV3, float f, float g)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector4* Transform(Microsoft.DirectX.Vector4* pOut, Microsoft.DirectX.Vector4* pSource, Microsoft.DirectX.Matrix* pSourceMatrix)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector4* TransformArray(Microsoft.DirectX.Vector4* pOut, int outStride, Microsoft.DirectX.Vector4* pSource, int vectorStride, Microsoft.DirectX.Matrix* pSourceMatrix, int count)
			{
				throw new NotImplementedException ();
			}
		}
		public sealed class Vector2
		{

			[CLSCompliant(false)]
			public unsafe static float Length(Microsoft.DirectX.Vector2* pSource)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static float LengthSq(Microsoft.DirectX.Vector2* pSource)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static float Dot(Microsoft.DirectX.Vector2* pLeft, Microsoft.DirectX.Vector2* pRight)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static float Ccw(Microsoft.DirectX.Vector2* pLeft, Microsoft.DirectX.Vector2* pRight)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector2* Add(Microsoft.DirectX.Vector2* pOut, Microsoft.DirectX.Vector2* pLeft, Microsoft.DirectX.Vector2* pRight)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector2* Subtract(Microsoft.DirectX.Vector2* pOut, Microsoft.DirectX.Vector2* pLeft, Microsoft.DirectX.Vector2* pRight)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector2* Minimize(Microsoft.DirectX.Vector2* pOut, Microsoft.DirectX.Vector2* pLeft, Microsoft.DirectX.Vector2* pRight)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector2* Maximize(Microsoft.DirectX.Vector2* pOut, Microsoft.DirectX.Vector2* pLeft, Microsoft.DirectX.Vector2* pRight)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector2* Scale(Microsoft.DirectX.Vector2* pOut, Microsoft.DirectX.Vector2* pSource, float scalingFactor)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector2* Lerp(Microsoft.DirectX.Vector2* pOut, Microsoft.DirectX.Vector2* pLeft, Microsoft.DirectX.Vector2* pRight, float interpolater)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector2* Normalize(Microsoft.DirectX.Vector2* pOut, Microsoft.DirectX.Vector2* pSource)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector2* Hermite(Microsoft.DirectX.Vector2* pOut, Microsoft.DirectX.Vector2* pPosition, Microsoft.DirectX.Vector2* pTangent, Microsoft.DirectX.Vector2* pPosition2, Microsoft.DirectX.Vector2* pTangent2, float weightingFactor)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector2* CatmullRom(Microsoft.DirectX.Vector2* pOut, Microsoft.DirectX.Vector2* pPosition1, Microsoft.DirectX.Vector2* pPosition2, Microsoft.DirectX.Vector2* pPosition3, Microsoft.DirectX.Vector2* pPosition4, float weightingFactor)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector2* BaryCentric(Microsoft.DirectX.Vector2* pOut, Microsoft.DirectX.Vector2* pV1, Microsoft.DirectX.Vector2* pV2, Microsoft.DirectX.Vector2* pV3, float f, float g)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector4* Transform(Microsoft.DirectX.Vector4* pOut, Microsoft.DirectX.Vector2* pSource, Microsoft.DirectX.Matrix* pSourceMatrix)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector4* TransformArray(Microsoft.DirectX.Vector4* pOut, int outStride, Microsoft.DirectX.Vector2* pSource, int vectorStride, Microsoft.DirectX.Matrix* pSourceMatrix, int count)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector2* TransformCoordinate(Microsoft.DirectX.Vector2* pOut, Microsoft.DirectX.Vector2* pSource, Microsoft.DirectX.Matrix* pSourceMatrix)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector2* TransformCoordinateArray(Microsoft.DirectX.Vector2* pOut, int outStride, Microsoft.DirectX.Vector2* pSource, int vectorStride, Microsoft.DirectX.Matrix* pSourceMatrix, int count)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector2* TransformNormal(Microsoft.DirectX.Vector2* pOut, Microsoft.DirectX.Vector2* pSource, Microsoft.DirectX.Matrix* pSourceMatrix)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector2* TransformNormalArray(Microsoft.DirectX.Vector2* pOut, int outStride, Microsoft.DirectX.Vector2* pSource, int vectorStride, Microsoft.DirectX.Matrix* pSourceMatrix, int count)
			{
				throw new NotImplementedException ();
			}
		}
		public sealed class Vector3
		{

			[CLSCompliant(false)]
			public unsafe static float Length(Microsoft.DirectX.Vector3* pSource)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static float LengthSq(Microsoft.DirectX.Vector3* pSource)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static float Dot(Microsoft.DirectX.Vector3* pLeft, Microsoft.DirectX.Vector3* pRight)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector3* Cross(Microsoft.DirectX.Vector3* pOut, Microsoft.DirectX.Vector3* pV1, Microsoft.DirectX.Vector3* pV2)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector3* Add(Microsoft.DirectX.Vector3* pOut, Microsoft.DirectX.Vector3* pLeft, Microsoft.DirectX.Vector3* pRight)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector3* Subtract(Microsoft.DirectX.Vector3* pOut, Microsoft.DirectX.Vector3* pLeft, Microsoft.DirectX.Vector3* pRight)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector3* Minimize(Microsoft.DirectX.Vector3* pOut, Microsoft.DirectX.Vector3* pLeft, Microsoft.DirectX.Vector3* pRight)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector3* Maximize(Microsoft.DirectX.Vector3* pOut, Microsoft.DirectX.Vector3* pLeft, Microsoft.DirectX.Vector3* pRight)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector3* Scale(Microsoft.DirectX.Vector3* pOut, Microsoft.DirectX.Vector3* pSource, float scalingFactor)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector3* Lerp(Microsoft.DirectX.Vector3* pOut, Microsoft.DirectX.Vector3* pLeft, Microsoft.DirectX.Vector3* pRight, float interpolater)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector3* Normalize(Microsoft.DirectX.Vector3* pOut, Microsoft.DirectX.Vector3* pSource)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector3* Hermite(Microsoft.DirectX.Vector3* pOut, Microsoft.DirectX.Vector3* pPosition, Microsoft.DirectX.Vector3* pTangent, Microsoft.DirectX.Vector3* pPosition2, Microsoft.DirectX.Vector3* pTangent2, float weightingFactor)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector3* CatmullRom(Microsoft.DirectX.Vector3* pOut, Microsoft.DirectX.Vector3* pPosition1, Microsoft.DirectX.Vector3* pPosition2, Microsoft.DirectX.Vector3* pPosition3, Microsoft.DirectX.Vector3* pPosition4, float weightingFactor)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector3* BaryCentric(Microsoft.DirectX.Vector3* pOut, Microsoft.DirectX.Vector3* pV1, Microsoft.DirectX.Vector3* pV2, Microsoft.DirectX.Vector3* pV3, float f, float g)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector4* Transform(Microsoft.DirectX.Vector4* pOut, Microsoft.DirectX.Vector3* pSource, Microsoft.DirectX.Matrix* pSourceMatrix)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector4* TransformArray(Microsoft.DirectX.Vector4* pOut, int outStride, Microsoft.DirectX.Vector3* pSource, int vectorStride, Microsoft.DirectX.Matrix* pSourceMatrix, int count)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector3* TransformCoordinate(Microsoft.DirectX.Vector3* pOut, Microsoft.DirectX.Vector3* pSource, Microsoft.DirectX.Matrix* pSourceMatrix)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector3* TransformCoordinateArray(Microsoft.DirectX.Vector3* pOut, int outStride, Microsoft.DirectX.Vector3* pSource, int vectorStride, Microsoft.DirectX.Matrix* pSourceMatrix, int count)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector3* TransformNormal(Microsoft.DirectX.Vector3* pOut, Microsoft.DirectX.Vector3* pSource, Microsoft.DirectX.Matrix* pSourceMatrix)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector3* TransformNormalArray(Microsoft.DirectX.Vector3* pOut, int outStride, Microsoft.DirectX.Vector3* pSource, int vectorStride, Microsoft.DirectX.Matrix* pSourceMatrix, int count)
			{
				throw new NotImplementedException ();
			}
		}
		public sealed class Plane
		{

			[CLSCompliant(false)]
			public unsafe static float Dot(Microsoft.DirectX.Plane* pPlane, Microsoft.DirectX.Vector4* pV)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static float DotCoordinate(Microsoft.DirectX.Plane* pPlane, Microsoft.DirectX.Vector3* pV)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static float DotNormal(Microsoft.DirectX.Plane* pPlane, Microsoft.DirectX.Vector3* pV)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Plane* Normalize(Microsoft.DirectX.Plane* pOut, Microsoft.DirectX.Plane* pPlane)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Vector3* IntersectLine(Microsoft.DirectX.Vector3* pOut, Microsoft.DirectX.Plane* pPlane, Microsoft.DirectX.Vector3* pV1, Microsoft.DirectX.Vector3* pV2)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Plane* FromPointNormal(Microsoft.DirectX.Plane* pOut, Microsoft.DirectX.Vector3* pPoint, Microsoft.DirectX.Vector3* pNormal)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Plane* FromPoints(Microsoft.DirectX.Plane* pOut, Microsoft.DirectX.Vector3* pPoint1, Microsoft.DirectX.Vector3* pPoint2, Microsoft.DirectX.Vector3* pPoint3)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Plane* Scale(Microsoft.DirectX.Plane* pOut, Microsoft.DirectX.Plane* pPlane, float s)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Plane* Transform(Microsoft.DirectX.Plane* pOut, Microsoft.DirectX.Plane* pPlane, Microsoft.DirectX.Matrix* pMatrix)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Plane* TransformArray(Microsoft.DirectX.Plane* pOut, int outStride, Microsoft.DirectX.Plane* pPlane, int vectorStride, Microsoft.DirectX.Matrix* pMatrix, int count)
			{
				throw new NotImplementedException ();
			}
		}
		public sealed class Quaternion
		{

			[CLSCompliant(false)]
			public unsafe static float Length(Microsoft.DirectX.Quaternion* pQuat)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static float LengthSq(Microsoft.DirectX.Quaternion* pQuat)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static float Dot(Microsoft.DirectX.Quaternion* pQuat1, Microsoft.DirectX.Quaternion* pQuat2)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static void ToAxisAngle(Microsoft.DirectX.Quaternion* pQuat, Microsoft.DirectX.Vector3* pAxis, float* pAngle)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Quaternion* Conjugate(Microsoft.DirectX.Quaternion* pOut, Microsoft.DirectX.Quaternion* pQuat)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Quaternion* RotationMatrix(Microsoft.DirectX.Quaternion* pOut, Microsoft.DirectX.Matrix* pMatrix)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Quaternion* RotationAxis(Microsoft.DirectX.Quaternion* pOut, Microsoft.DirectX.Vector3* pAxis, float angle)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Quaternion* Multiply(Microsoft.DirectX.Quaternion* pOut, Microsoft.DirectX.Quaternion* pQuat1, Microsoft.DirectX.Quaternion* pQuat2)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Quaternion* Normalize(Microsoft.DirectX.Quaternion* pOut, Microsoft.DirectX.Quaternion* pQuat)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Quaternion* Invert(Microsoft.DirectX.Quaternion* pOut, Microsoft.DirectX.Quaternion* pQuat)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Quaternion* Ln(Microsoft.DirectX.Quaternion* pOut, Microsoft.DirectX.Quaternion* pQuat)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Quaternion* Exp(Microsoft.DirectX.Quaternion* pOut, Microsoft.DirectX.Quaternion* pQuat)
			{
				throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Quaternion* Slerp(Microsoft.DirectX.Quaternion* pOut, Microsoft.DirectX.Quaternion* pQuat1, Microsoft.DirectX.Quaternion* pQuat2, float t)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Quaternion* Squad(Microsoft.DirectX.Quaternion* pOut, Microsoft.DirectX.Quaternion* pQuat1, Microsoft.DirectX.Quaternion* pQuata, Microsoft.DirectX.Quaternion* pQuatb, Microsoft.DirectX.Quaternion* pQuatc, float t)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static Microsoft.DirectX.Quaternion* BaryCentric(Microsoft.DirectX.Quaternion* pOut, Microsoft.DirectX.Quaternion* pQuat1, Microsoft.DirectX.Quaternion* pQuat2, Microsoft.DirectX.Quaternion* pQuat3, float f, float g)
			{
			throw new NotImplementedException ();
			}
			[CLSCompliant(false)]
			public unsafe static void SquadSetup(Microsoft.DirectX.Quaternion* pOutA, Microsoft.DirectX.Quaternion* pOutB, Microsoft.DirectX.Quaternion* pOutC, Microsoft.DirectX.Quaternion* pQ0, Microsoft.DirectX.Quaternion* pQ1, Microsoft.DirectX.Quaternion* pQ2, Microsoft.DirectX.Quaternion* pQ3)
			{
				throw new NotImplementedException ();
			}
		}
	}
}
