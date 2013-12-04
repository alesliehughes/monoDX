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
	public sealed class PatchMesh : MarshalByRefObject, IDisposable
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
		public unsafe  ID3DXPatchMesh* UnmanagedComPointer {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool Disposed {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public DisplacementParameter DisplacementParameter {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public  IndexBuffer IndexBuffer {
			get {
				throw new NotImplementedException ();
			}
		}

		public  VertexBuffer VertexBuffer {
			get {
				throw new NotImplementedException ();
			}
		}

		public  PatchInformation PatchInformation {
			get {
				throw new NotImplementedException ();
			}
		}

		public  Device Device {
			get {
				throw new NotImplementedException ();
			}
		}

		public  MeshOptions Options {
			get {
				throw new NotImplementedException ();
			}
		}

		public  int ControlVerticesPerPatch {
			get {
				throw new NotImplementedException ();
			}
		}

		public  VertexElement[] Declaration {
			get {
				throw new NotImplementedException ();
			}
		}

		public  int NumberVertices {
			get {
				throw new NotImplementedException ();
			}
		}

		public  int NumberPatches {
			get {
				throw new NotImplementedException ();
			}
		}

		static PatchMesh ()
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe PatchMesh (ID3DXPatchMesh* pUnk)
		{
			throw new NotImplementedException ();
		}

		public  PatchMesh (IntPtr unmanagedObject)
		{
			throw new NotImplementedException ();
		}

		public  PatchMesh (Device device, PatchInformation information, int numberPatches, int numberVertices, VertexElement[] declaration)
		{
			throw new NotImplementedException ();
		}
		
		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator == (PatchMesh left, PatchMesh right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (PatchMesh left, PatchMesh right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}

		public  GraphicsStream LockVertexBuffer (LockFlags flags)
		{
			throw new NotImplementedException ();
		}

		public  Array LockVertexBuffer (Type typeVertex, LockFlags flags, params int[] ranks)
		{
			throw new NotImplementedException ();
		}

		public  void UnlockVertexBuffer ()
		{
			throw new NotImplementedException ();
		}

		public  Array LockIndexBuffer (Type typeIndex, LockFlags flags, params int[] ranks)
		{
			throw new NotImplementedException ();
		}

		public  GraphicsStream LockIndexBuffer (LockFlags flags)
		{
			throw new NotImplementedException ();
		}

		public  void UnlockIndexBuffer ()
		{
			throw new NotImplementedException ();
		}

		public  void SetVertexBufferData (object data, LockFlags flags)
		{
			throw new NotImplementedException ();
		}

		public  void SetIndexBufferData (object data, LockFlags flags)
		{
			throw new NotImplementedException ();
		}

		public  int[] LockAttributeBufferArray (LockFlags flags)
		{
			throw new NotImplementedException ();
		}

		public  void UnlockAttributeBuffer ()
		{
			throw new NotImplementedException ();
		}

		public  void UnlockAttributeBuffer (int[] dataAttribute)
		{
			throw new NotImplementedException ();
		}

		public  GraphicsStream LockAttributeBuffer (LockFlags flags)
		{
			throw new NotImplementedException ();
		}

		public  void GetTessellateSize (float tessLevel, int adaptive, out int numTriangles, out int numVertices)
		{
			throw new NotImplementedException ();
		}

		public  void GenerateAdjacency (float tolerance)
		{
			throw new NotImplementedException ();
		}

		public  PatchMesh Clone (MeshFlags options, GraphicsStream decl)
		{
			throw new NotImplementedException ();
		}

		public  PatchMesh Clone (MeshFlags options, VertexElement[] decl)
		{
			throw new NotImplementedException ();
		}

		public  void Optimize ()
		{
			throw new NotImplementedException ();
		}

		public  void Tessellate (float tessLevel, Mesh mesh)
		{
			throw new NotImplementedException ();
		}

		public  void TessellateAdaptive (Vector4 trans, int maxTessellate, int minTessellate, Mesh mesh)
		{
			throw new NotImplementedException ();
		}

		public  void Dispose ()
		{
			throw new NotImplementedException ();
		}

		public static PatchMesh FromX (XFileData xofObjMesh, MeshFlags options, Device device, out EffectInstance[] effects)
		{
			throw new NotImplementedException ();
		}

		public static PatchMesh FromX (XFileData xofObjMesh, MeshFlags options, Device device)
		{
			throw new NotImplementedException ();
		}

		public static PatchMesh FromX (XFileData xofObjMesh, MeshFlags options, Device device, out ExtendedMaterial[] materials)
		{
			throw new NotImplementedException ();
		}

		public  static PatchMesh FromX (XFileData xofObjMesh, MeshFlags options, Device device, out ExtendedMaterial[] materials, out EffectInstance[] effects)
		{
			throw new NotImplementedException ();
		}

		public  static PatchMesh CreateNPatchMesh (Mesh mesh)
		{
			throw new NotImplementedException ();
		}

		public DegenerateItems Validate ()
		{
			throw new NotImplementedException ();
		}

		public  DegenerateItems Validate (out string errorsAndWarnings)
		{
			throw new NotImplementedException ();
		}
		
		[CLSCompliant(false)]
		public unsafe void UpdateUnmanagedPointer (ID3DXPatchMesh* pInterface)
		{
			throw new NotImplementedException ();
		}

		[EditorBrowsable]
		public  IntPtr GetObjectByValue (int uniqueKey)
		{
			throw new NotImplementedException ();
		}

	}
}

