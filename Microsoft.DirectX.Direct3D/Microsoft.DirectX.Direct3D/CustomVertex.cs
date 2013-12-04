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
using Microsoft.DirectX;

namespace Microsoft.DirectX.Direct3D
{
	public sealed class CustomVertex
	{
		
		public struct Transformed
		{
			public static int StrideSize {
				get {
					throw new NotImplementedException ();
				}
			}

			public Vector4 Position {
				get {
					throw new NotImplementedException ();
				}
				set {
					throw new NotImplementedException ();
				}
			}

			public override string ToString ()
			{
				throw new NotImplementedException ();
			}

			public Transformed (Vector4 value)
			{
				throw new NotImplementedException ();
			}

			public Transformed (float xvalue, float yvalue, float zvalue, float rhwvalue)
			{
				throw new NotImplementedException ();
			}
		}

		
		public struct TransformedTextured
		{
			public static int StrideSize {
				get {
					throw new NotImplementedException ();
				}
			}

			public Vector4 Position {
				get {
					throw new NotImplementedException ();
				}
				set {
					throw new NotImplementedException ();
				}
			}

			public override string ToString ()
			{
				throw new NotImplementedException ();
			}

			public TransformedTextured (Vector4 value, float u, float v)
			{
				throw new NotImplementedException ();
			}

			public TransformedTextured (float xvalue, float yvalue, float zvalue, float rhwvalue, float u, float v)
			{
				throw new NotImplementedException ();
			}
		}

		
		public struct TransformedColored
		{
		
			public static int StrideSize {
				get {
					throw new NotImplementedException ();
				}
			}

			public Vector4 Position {
				get {
					throw new NotImplementedException ();
				}
				set {
					throw new NotImplementedException ();
				}
			}

			public override string ToString ()
			{
				throw new NotImplementedException ();
			}

			public TransformedColored (Vector4 value, int c)
			{
				throw new NotImplementedException ();
			}

			public TransformedColored (float xvalue, float yvalue, float zvalue, float rhwvalue, int c)
			{
				throw new NotImplementedException ();
			}
		}

		
		public struct TransformedColoredTextured
		{
			public float X;
			public float Y;
			public float Z;
			public float Rhw;
			public int Color;
			public float Tu;
			public float Tv;
			public const VertexFormats Format = VertexFormats.Texture1 | VertexFormats.Diffuse | VertexFormats.Transformed | VertexFormats.Position;
			
			public static int StrideSize {
				get {
					throw new NotImplementedException ();
				}
			}

			public Vector4 Position {
				get {
					throw new NotImplementedException ();
				}
				set {
					throw new NotImplementedException ();
				}
			}

			public override string ToString ()
			{
				throw new NotImplementedException ();
			}

			public TransformedColoredTextured (Vector4 value, int c, float u, float v)
			{
				throw new NotImplementedException ();
			}

			public TransformedColoredTextured (float xvalue, float yvalue, float zvalue, float rhwvalue, int c, float u, float v)
			{
				throw new NotImplementedException ();
			}
		}

		
		public struct PositionOnly
		{
		
			public static int StrideSize {
				get {
					throw new NotImplementedException ();
				}
			}

			public Vector3 Position {
				get {
					throw new NotImplementedException ();
				}
				set {
					throw new NotImplementedException ();
				}
			}

			public override string ToString ()
			{
				throw new NotImplementedException ();
			}

			public PositionOnly (Vector3 value)
			{
				throw new NotImplementedException ();
			}

			public PositionOnly (float xvalue, float yvalue, float zvalue)
			{
				throw new NotImplementedException ();
			}
		}

		
		public struct PositionNormal
		{
		
			public static int StrideSize {
				get {
					throw new NotImplementedException ();
				}
			}

			public Vector3 Normal {
				get {
					throw new NotImplementedException ();
				}
				set {
					throw new NotImplementedException ();
				}
			}

			public Vector3 Position {
				get {
					throw new NotImplementedException ();
				}
				set {
					throw new NotImplementedException ();
				}
			}

			public override string ToString ()
			{
				throw new NotImplementedException ();
			}

			public PositionNormal (Vector3 pos, Vector3 nor)
			{
				throw new NotImplementedException ();
			}

			public PositionNormal (float xvalue, float yvalue, float zvalue, float nxvalue, float nyvalue, float nzvalue)
			{
				throw new NotImplementedException ();
			}
		}

		
		public struct PositionColored
		{
		
			public static int StrideSize {
				get {
					throw new NotImplementedException ();
				}
			}

			public Vector3 Position {
				get {
					throw new NotImplementedException ();
				}
				set {
					throw new NotImplementedException ();
				}
			}

			public override string ToString ()
			{
				throw new NotImplementedException ();
			}

			public PositionColored (Vector3 value, int c)
			{
				throw new NotImplementedException ();
			}

			public PositionColored (float xvalue, float yvalue, float zvalue, int c)
			{
				throw new NotImplementedException ();
			}
		}

		
		public struct PositionNormalColored
		{
		
			public static int StrideSize {
				get {
					throw new NotImplementedException ();
				}
			}

			public Vector3 Normal {
				get {
					throw new NotImplementedException ();
				}
				set {
					throw new NotImplementedException ();
				}
			}

			public Vector3 Position {
				get {
					throw new NotImplementedException ();
				}
				set {
					throw new NotImplementedException ();
				}
			}

			public override string ToString ()
			{
				throw new NotImplementedException ();
			}

			public PositionNormalColored (Vector3 pos, Vector3 nor, int c)
			{
				throw new NotImplementedException ();
			}

			public PositionNormalColored (float xvalue, float yvalue, float zvalue, float nxvalue, float nyvalue, float nzvalue, int c)
			{
				throw new NotImplementedException ();
			}
		}

		
		public struct PositionNormalTextured
		{
	
			public static int StrideSize {
				get {
					throw new NotImplementedException ();
				}
			}

			public Vector3 Normal {
				get {
					throw new NotImplementedException ();
				}
				set {
					throw new NotImplementedException ();
				}
			}

			public Vector3 Position {
				get {
					throw new NotImplementedException ();
				}
				set {
					throw new NotImplementedException ();
				}
			}

			public override string ToString ()
			{
				throw new NotImplementedException ();
			}

			public PositionNormalTextured (Vector3 pos, Vector3 nor, float u, float v)
			{
				throw new NotImplementedException ();
			}

			public PositionNormalTextured (float xvalue, float yvalue, float zvalue, float nxvalue, float nyvalue, float nzvalue, float u, float v)
			{
				throw new NotImplementedException ();
			}
		}

		
		public struct PositionTextured
		{
		
			public static int StrideSize {
				get {
					throw new NotImplementedException ();
				}
			}

			public Vector3 Position {
				get {
					throw new NotImplementedException ();
				}
				set {
					throw new NotImplementedException ();
				}
			}

			public override string ToString ()
			{
				throw new NotImplementedException ();
			}

			public PositionTextured (Vector3 pos, float u, float v)
			{
				throw new NotImplementedException ();
			}

			public PositionTextured (float xvalue, float yvalue, float zvalue, float u, float v)
			{
				throw new NotImplementedException ();
			}
		}


		public struct PositionColoredTextured
		{
	
			public static int StrideSize {
				get {
					throw new NotImplementedException ();
				}
			}

			public Vector3 Position {
				get {
					throw new NotImplementedException ();
				}
				set {
					throw new NotImplementedException ();
				}
			}

			public override string ToString ()
			{
				throw new NotImplementedException ();
			}

			public PositionColoredTextured (Vector3 value, int c, float u, float v)
			{
			
			}

			public PositionColoredTextured (float xvalue, float yvalue, float zvalue, int c, float u, float v)
			{
		
			}
		}

	}
}