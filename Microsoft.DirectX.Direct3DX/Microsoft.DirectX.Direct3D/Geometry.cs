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

namespace Microsoft.DirectX.Direct3D
{
	public sealed class Geometry
	{
		static Geometry ()
		{
		}

		public static Mesh ComputeTangentFrame (Mesh mesh, int textureInSemantic, int textureInIndex, int upartialOutSemantic, int upartialOutIndex, int vpartialOutSemantic, int vpartialOutIndex, int normalOutSemantic, int normalOutIndex, TangentOptions options, GraphicsStream adjacency, float partialEdgeTreshold, float singularPointThreshold, float normalEdgeThreshold, out GraphicsStream vertexRemapping)
		{
			throw new NotImplementedException ();
		}

		public static float DegreeToRadian (float degree)
		{
			throw new NotImplementedException ();
		}

		public static float RadianToDegree (float radian)
		{
			throw new NotImplementedException ();
		}

		public static float FresnelTerm (float cosTheta, float refractionIndex)
		{
			throw new NotImplementedException ();
		}

		public static float ComputeBoundingSphere (GraphicsStream pointsFvf, int numVertices, VertexFormats vertexFormat, out Vector3 center)
		{
			throw new NotImplementedException ();
		}

		public static float ComputeBoundingSphere (Array pointsFvf, VertexFormats vertexFormat, out Vector3 center)
		{
			throw new NotImplementedException ();
		}

		public static float ComputeBoundingSphere (GraphicsStream pointsFvf, int numVertices, int strideSize, out Vector3 center)
		{
			throw new NotImplementedException ();
		}

		public static float ComputeBoundingSphere (Array pointsFvf, int strideSize, out Vector3 center)
		{
			throw new NotImplementedException ();
		}

		public static void ComputeBoundingBox (GraphicsStream pointsFvf, int numVertices, VertexFormats vertexFormat, out Vector3 min, out Vector3 max)
		{
			throw new NotImplementedException ();
		}

		public static void ComputeBoundingBox (Array pointsFvf, VertexFormats vertexFormat, out Vector3 min, out Vector3 max)
		{
			throw new NotImplementedException ();
		}

		public static void ComputeBoundingBox (GraphicsStream pointsFvf, int numVertices, int strideSize, out Vector3 min, out Vector3 max)
		{
			throw new NotImplementedException ();
		}

		public static void ComputeBoundingBox (Array pointsFvf, int strideSize, out Vector3 min, out Vector3 max)
		{
			throw new NotImplementedException ();
		}
		
		public static bool IntersectTri (Vector3 zero, Vector3 one, Vector3 two, Vector3 rayPos, Vector3 rayDir, out IntersectInformation hitLocation)
		{
			throw new NotImplementedException ();
		}
		
		public static bool SphereBoundProbe (Vector3 center, float radius, Vector3 rayPosition, Vector3 rayDirection)
		{
			throw new NotImplementedException ();
		}
		
		public static bool BoxBoundProbe (Vector3 min, Vector3 max, Vector3 rayPosition, Vector3 rayDirection)
		{
			throw new NotImplementedException ();
		}
		
		public static int[] OptimizeFaces (int[] indices, int numberVertices)
		{
			throw new NotImplementedException ();
		}

		public static int[] OptimizeFaces (short[] indices, int numberVertices)
		{
			throw new NotImplementedException ();
		}

		public static int[] OptimizeVertices (int[] indices, int numberVertices)
		{
			throw new NotImplementedException ();
		}

		public static int[] OptimizeVertices (short[] indices, int numberVertices)
		{
			throw new NotImplementedException ();
		}
		
	}
}
