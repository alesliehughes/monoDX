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
using Microsoft.DirectX.PrivateImplementationDetails;
using System.ComponentModel;

namespace Microsoft.DirectX.Direct3D
{
	public sealed class ProgressiveMesh : BaseMesh, IDisposable
	{
		public new event EventHandler Disposing {

			add {
				throw new NotImplementedException ();
			}
			
			remove {
				throw new NotImplementedException ();
			}
		}

		[CLSCompliant(false)]
		public unsafe new ID3DXPMesh* UnmanagedComPointer {
			get {
				throw new NotImplementedException ();
			}
		}

		public new bool Disposed {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public int[] Adjacency {
			get {
				throw new NotImplementedException ();
			}
		}

		public int MinVertices {
			get {
				throw new NotImplementedException ();
			}
		}

		public int MaxVertices {
			get {
				throw new NotImplementedException ();
			}
		}

		public int MinFaces {
			get {
				throw new NotImplementedException ();
			}
		}

		public int MaxFaces {
			get {
				throw new NotImplementedException ();
			}
		}

		public new int NumberVertices {
			set {
				throw new NotImplementedException ();
			}
		}

		public new int NumberFaces {
			set {
				throw new NotImplementedException ();
			}
		}

		[CLSCompliant(false)]
		public unsafe ProgressiveMesh (ID3DXPMesh* pInterop) : base(null)
		{
			throw new NotImplementedException ();
		}

		public unsafe ProgressiveMesh (IntPtr unmanagedObject) : base(null)
		{
			throw new NotImplementedException ();
		}

		public unsafe ProgressiveMesh (Mesh mesh, int[] adjacency, int minValue, MeshFlags options) : base(null)
		{
			throw new NotImplementedException ();
		}

		public unsafe ProgressiveMesh (Mesh mesh, int[] adjacency, float[] vertexWeights, int minValue, MeshFlags options) : base(null)
		{
			throw new NotImplementedException ();
		}

		public unsafe ProgressiveMesh (Mesh mesh, int[] adjacency, AttributeWeights vertexAttributeWeights, int minValue, MeshFlags options) : base(null)
		{
			throw new NotImplementedException ();
		}

		public unsafe ProgressiveMesh (Mesh mesh, int[] adjacency, AttributeWeights vertexAttributeWeights, float[] vertexWeights, int minValue, MeshFlags options) : base(null)
		{
			throw new NotImplementedException ();
		}

		public unsafe ProgressiveMesh (Mesh mesh, GraphicsStream adjacency, GraphicsStream vertexWeights, int minValue, MeshFlags options) : base(null)
		{
			throw new NotImplementedException ();
		}

		public unsafe ProgressiveMesh (Mesh mesh, GraphicsStream adjacency, AttributeWeights vertexAttributeWeights, GraphicsStream vertexWeights, int minValue, MeshFlags options) : base(null)
		{
			throw new NotImplementedException ();
		}
	
		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator == (ProgressiveMesh left, ProgressiveMesh right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (ProgressiveMesh left, ProgressiveMesh right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}
		
		public new ProgressiveMesh Clone (MeshFlags options, GraphicsStream declaration, Device device)
		{
			throw new NotImplementedException ();
		}

		public new ProgressiveMesh Clone (MeshFlags options, VertexElement[] declaration, Device device)
		{
			throw new NotImplementedException ();
		}

		public new ProgressiveMesh Clone (MeshFlags options, VertexFormats vertexFormat, Device device)
		{
			throw new NotImplementedException ();
		}

		public void OptimizeBaseLevelOfDetail (MeshFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void OptimizeBaseLevelOfDetail (MeshFlags flags, out int[] faceRemap)
		{
			throw new NotImplementedException ();
		}

		public Mesh Optimize (MeshFlags flags)
		{
			throw new NotImplementedException ();
		}

		public Mesh Optimize (MeshFlags flags, out int[] adjacencyOut, out int[] faceRemap)
		{
			throw new NotImplementedException ();
		}

		public Mesh Optimize (MeshFlags flags, out int[] adjacencyOut, out int[] faceRemap, out GraphicsStream vertexRemap)
		{
			throw new NotImplementedException ();
		}

		public void TrimByFaces (int newFacesMin, int newFacesMax)
		{
			throw new NotImplementedException ();
		}

		public void TrimByFaces (int newFacesMin, int newFacesMax, out int[] faceRemap, out int[] vertRemap)
		{
			throw new NotImplementedException ();
		}

		public void TrimByVertices (int newVerticesMin, int newVerticesMax)
		{
			throw new NotImplementedException ();
		}

		public void TrimByVertices (int newVerticesMin, int newVerticesMax, out int[] faceRemap, out int[] vertRemap)
		{
			throw new NotImplementedException ();
		}

		public new void Dispose ()
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void UpdateUnmanagedPointer (ID3DXPMesh* pInterface)
		{
			throw new NotImplementedException ();
		}

		[EditorBrowsable]
		public new IntPtr GetObjectByValue (int uniqueKey)
		{
			throw new NotImplementedException ();
		}

	}
}

