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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.DirectX.PrivateImplementationDetails;
using Microsoft.DirectX.Direct3DX;

namespace Microsoft.DirectX.Direct3D
{
	public abstract class BaseMesh : MarshalByRefObject, IDisposable
	{
		public event EventHandler Disposing {

			add {
				throw new NotImplementedException ();
			}

			remove {
				throw new NotImplementedException ();
			}
		}

		[CLSCompliant(false)]
		public unsafe ID3DXBaseMesh* UnmanagedComPointer {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool Disposed {
			get {
				throw new NotImplementedException ();
			}
		}

		public int NumberAttributes {
			get {
				throw new NotImplementedException ();
			}
		}

		public IndexBuffer IndexBuffer {
			get {
				throw new NotImplementedException ();
			}
		}

		public VertexBuffer VertexBuffer {
			get {
				throw new NotImplementedException ();
			}
		}

		public Device Device {
			get {
				throw new NotImplementedException ();
			}
		}

		public MeshOptions Options {
			get {
				throw new NotImplementedException ();
			}
		}

		public VertexElement[] Declaration {
			get {
				throw new NotImplementedException ();
			}
		}

		public int NumberBytesPerVertex {
			get {
				throw new NotImplementedException ();
			}
		}

		public VertexFormats VertexFormat {
			get {
				throw new NotImplementedException ();
			}
		}

		public int NumberVertices {
			get {
				throw new NotImplementedException ();
			}
		}

		public unsafe int NumberFaces {
			get {
				throw new NotImplementedException ();
			}
		}

		static BaseMesh ()
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe BaseMesh (ID3DXBaseMesh* pUnk)
		{
			throw new NotImplementedException ();
		}

		public unsafe BaseMesh (IntPtr unmanagedObject)
		{
			throw new NotImplementedException ();
		}
		
		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator == (BaseMesh left, BaseMesh right)
		{
			throw new NotImplementedException ();
		}

		public static bool operator != (BaseMesh left, BaseMesh right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}

		public void DrawSubset (int attributeID)
		{
			throw new NotImplementedException ();
		}

		public void GenerateAdjacency (float epsilon, int[] adjacency)
		{
			throw new NotImplementedException ();
		}

		public int[] ConvertAdjacencyToPointReps (GraphicsStream adjacency)
		{
			throw new NotImplementedException ();
		}

		public int[] ConvertAdjacencyToPointReps (int[] adjaceny)
		{
			throw new NotImplementedException ();
		}

		public int[] ConvertPointRepsToAdjacency (GraphicsStream pointReps)
		{
			throw new NotImplementedException ();
		}

		public int[] ConvertPointRepsToAdjacency (int[] pointReps)
		{
			throw new NotImplementedException ();
		}

		public AttributeRange[] GetAttributeTable ()
		{
			throw new NotImplementedException ();
		}

		public void Dispose ()
		{
			throw new NotImplementedException ();
		}

		public Mesh Clone (MeshFlags options, GraphicsStream declaration, Device device)
		{
			throw new NotImplementedException ();
		}

		public Mesh Clone (MeshFlags options, VertexElement[] declaration, Device device)
		{
			throw new NotImplementedException ();
		}

		public Mesh Clone (MeshFlags options, VertexFormats vertexFormat, Device device)
		{
			throw new NotImplementedException ();
		}

		public void UpdateSemantics (GraphicsStream declaration)
		{
			throw new NotImplementedException ();
		}

		public unsafe void UpdateSemantics (VertexElement[] declaration)
		{
			throw new NotImplementedException ();
		}

		public GraphicsStream LockVertexBuffer (LockFlags flags)
		{
			throw new NotImplementedException ();
		}

		public unsafe Array LockVertexBuffer (Type typeVertex, LockFlags flags, params int[] ranks)
		{
			throw new NotImplementedException ();
		}

		public void UnlockVertexBuffer ()
		{
			throw new NotImplementedException ();
		}

		public unsafe Array LockIndexBuffer (Type typeIndex, LockFlags flags, params int[] ranks)
		{
			throw new NotImplementedException ();
		}

		public GraphicsStream LockIndexBuffer (LockFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void UnlockIndexBuffer ()
		{
			throw new NotImplementedException ();
		}

		public void SetVertexBufferData (object data, LockFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void SetIndexBufferData (object data, LockFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void ComputeNormals ()
		{
			throw new NotImplementedException ();
		}

		public void ComputeNormals (int[] adjacency)
		{
			throw new NotImplementedException ();
		}

		public void ComputeNormals (GraphicsStream adjacency)
		{
			throw new NotImplementedException ();
		}
		
		[CLSCompliant(false)]
		public unsafe void UpdateUnmanagedPointer (ID3DXBaseMesh* pInterface)
		{
			throw new NotImplementedException ();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public unsafe IntPtr GetObjectByValue (int uniqueKey)
		{
			throw new NotImplementedException ();
		}
		
	}
}
