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
using Microsoft.DirectX.PrivateImplementationDetails;
using System;
using Microsoft.DirectX.Direct3DX;
using System.IO;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace Microsoft.DirectX.Direct3D
{
	public sealed class Mesh : BaseMesh, IDisposable
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
		public new unsafe ID3DXMesh* UnmanagedComPointer {
			get {
				throw new NotImplementedException ();
			}
		}

		public new bool Disposed {

			get {
				throw new NotImplementedException ();
			}
		}

		[CLSCompliant(false)]
		public unsafe Mesh (ID3DXMesh* pInterop) : base( (IntPtr)null)
		{
			throw new NotImplementedException ();
		}

		public unsafe Mesh (IntPtr unmanagedObject) : base((IntPtr)null)
		{
			throw new NotImplementedException ();
		}

		public Mesh (int numFaces, int numVertices, MeshFlags options, VertexFormats vertexFormat, Device device) : base( (IntPtr)null)
		{
			throw new NotImplementedException ();
		}

		public Mesh (int numFaces, int numVertices, MeshFlags options, GraphicsStream declaration, Device device) : base( (IntPtr)null)
		{
			throw new NotImplementedException ();
		}

		public unsafe Mesh (int numFaces, int numVertices, MeshFlags options, VertexElement[] declaration, Device device) : base( (IntPtr)null)
		{
			throw new NotImplementedException ();
		}

		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}

		public static bool operator == (Mesh left, Mesh right)
		{
			throw new NotImplementedException ();
		}

		public static bool operator != (Mesh left, Mesh right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}

		public Mesh Optimize (MeshFlags flags, GraphicsStream adjacencyIn)
		{
			throw new NotImplementedException ();
		}

		public Mesh Optimize (MeshFlags flags, GraphicsStream adjacencyIn, out int[] adjacencyOut, out int[] faceRemap, out GraphicsStream vertexRemap)
		{
			throw new NotImplementedException ();
		}

		public Mesh Optimize (MeshFlags flags, int[] adjacencyIn)
		{
			throw new NotImplementedException ();
		}

		public Mesh Optimize (MeshFlags flags, int[] adjacencyIn, out int[] adjacencyOut, out int[] faceRemap, out GraphicsStream vertexRemap)
		{
			throw new NotImplementedException ();
		}

		public void OptimizeInPlace (MeshFlags flags, GraphicsStream adjacencyIn)
		{
			throw new NotImplementedException ();
		}

		public void OptimizeInPlace (MeshFlags flags, int[] adjacencyIn)
		{
			throw new NotImplementedException ();
		}

		public void OptimizeInPlace (MeshFlags flags, GraphicsStream adjacencyIn, out int[] adjacencyOut, out int[] faceRemap, out GraphicsStream vertexRemap)
		{
			throw new NotImplementedException ();
		}

		public void OptimizeInPlace (MeshFlags flags, int[] adjacencyIn, out int[] adjacencyOut, out int[] faceRemap, out GraphicsStream vertexRemap)
		{
			throw new NotImplementedException ();
		}

		public int[] LockAttributeBufferArray (LockFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void UnlockAttributeBuffer ()
		{
			throw new NotImplementedException ();
		}

		public void UnlockAttributeBuffer (int[] dataAttribute)
		{
			throw new NotImplementedException ();
		}

		public GraphicsStream LockAttributeBuffer (LockFlags flags)
		{
			throw new NotImplementedException ();
		}

		public unsafe void SetAttributeTable (AttributeRange[] table)
		{
			throw new NotImplementedException ();
		}

		public new void Dispose ()
		{
			throw new NotImplementedException ();
		}

		public void ComputeTangentFrame (TangentOptions options)
		{
			throw new NotImplementedException ();
		}

		public void Validate (int[] adjacency)
		{
			throw new NotImplementedException ();
		}

		public void Validate (int[] adjacency, out string errorsAndWarnings)
		{
			throw new NotImplementedException ();
		}

		public void Validate (GraphicsStream adjacency)
		{
			throw new NotImplementedException ();
		}

		public void Validate (GraphicsStream adjacency, out string errorsAndWarnings)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Clean (CleanType cleanType, Mesh mesh, int[] adjacency, out int[] adjacencyOut)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Clean (CleanType cleanType, Mesh mesh, int[] adjacency, out int[] adjacencyOut, out string errorsAndWarnings)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Clean (CleanType cleanType, Mesh mesh, GraphicsStream adjacency, GraphicsStream adjacencyOut)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Clean (CleanType cleanType, Mesh mesh, GraphicsStream adjacency, GraphicsStream adjacencyOut, out string errorsAndWarnings)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Polygon (Device device, float length, int sides)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Polygon (Device device, float length, int sides, out GraphicsStream adjacency)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Box (Device device, float width, float height, float depth)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Box (Device device, float width, float height, float depth, out GraphicsStream adjacency)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Cylinder (Device device, float radius1, float radius2, float length, int slices, int stacks)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Cylinder (Device device, float radius1, float radius2, float length, int slices, int stacks, out GraphicsStream adjacency)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Sphere (Device device, float radius, int slices, int stacks)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Sphere (Device device, float radius, int slices, int stacks, out GraphicsStream adjacency)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Torus (Device device, float innerRadius, float outerRadius, int sides, int rings)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Torus (Device device, float innerRadius, float outerRadius, int sides, int rings, out GraphicsStream adjacency)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Teapot (Device device)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Teapot (Device device, out GraphicsStream adjacency)
		{
			throw new NotImplementedException ();
		}

		public static Mesh TextFromFont (Device device, Font font, string text, float deviation, float extrusion)
		{
			throw new NotImplementedException ();
		}

		public static Mesh TextFromFont (Device device, Font font, string text, float deviation, float extrusion, out GlyphMetricsFloat[] glyphMetrics)
		{
			throw new NotImplementedException ();
		}

		public static Mesh TextFromFont (Device device, Font font, string text, float deviation, float extrusion, out GraphicsStream adjacency)
		{
			throw new NotImplementedException ();
		}

		public static Mesh TextFromFont (Device device, Font font, string text, float deviation, float extrusion, out GraphicsStream adjacency, out GlyphMetricsFloat[] glyphMetrics)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Simplify (Mesh mesh, int[] adjacency, int minValue, MeshFlags options)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Simplify (Mesh mesh, int[] adjacency, float[] vertexWeights, int minValue, MeshFlags options)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Simplify (Mesh mesh, int[] adjacency, AttributeWeights vertexAttributeWeights, int minValue, MeshFlags options)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Simplify (Mesh mesh, int[] adjacency, AttributeWeights vertexAttributeWeights, float[] vertexWeights, int minValue, MeshFlags options)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Simplify (Mesh mesh, GraphicsStream adjacency, GraphicsStream vertexWeights, int minValue, MeshFlags options)
		{
			throw new NotImplementedException ();
		}

		public static Mesh Simplify (Mesh mesh, GraphicsStream adjacency, AttributeWeights vertexAttributeWeights, GraphicsStream vertexWeights, int minValue, MeshFlags options)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromStream (Stream stream, MeshFlags options, Device device, out EffectInstance[] effects)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromStream (Stream stream, MeshFlags options, Device device, out GraphicsStream adjacency, out EffectInstance[] effects)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromStream (Stream stream, MeshFlags options, Device device, out ExtendedMaterial[] materials, out EffectInstance[] effects)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromStream (Stream stream, MeshFlags options, Device device)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromStream (Stream stream, MeshFlags options, Device device, out GraphicsStream adjacency)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromStream (Stream stream, MeshFlags options, Device device, out ExtendedMaterial[] materials)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromStream (Stream stream, MeshFlags options, Device device, out GraphicsStream adjacency, out ExtendedMaterial[] materials)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromStream (Stream stream, int readBytes, MeshFlags options, Device device, out EffectInstance[] effects)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromStream (Stream stream, int readBytes, MeshFlags options, Device device, out GraphicsStream adjacency, out EffectInstance[] effects)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromStream (Stream stream, int readBytes, MeshFlags options, Device device, out ExtendedMaterial[] materials, out EffectInstance[] effects)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromStream (Stream stream, int readBytes, MeshFlags options, Device device)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromStream (Stream stream, int readBytes, MeshFlags options, Device device, out GraphicsStream adjacency)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromStream (Stream stream, int readBytes, MeshFlags options, Device device, out ExtendedMaterial[] materials)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromStream (Stream stream, int readBytes, MeshFlags options, Device device, out GraphicsStream adjacency, out ExtendedMaterial[] materials)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromStream (Stream stream, int readBytes, MeshFlags options, Device device, out GraphicsStream adjacency, out ExtendedMaterial[] materials, out EffectInstance[] effects)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromFile (string filename, MeshFlags options, Device device, out EffectInstance[] effects)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromFile (string filename, MeshFlags options, Device device, out GraphicsStream adjacency, out EffectInstance[] effects)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromFile (string filename, MeshFlags options, Device device, out ExtendedMaterial[] materials, out EffectInstance[] effects)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromFile (string filename, MeshFlags options, Device device)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromFile (string filename, MeshFlags options, Device device, out GraphicsStream adjacency)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromFile (string filename, MeshFlags options, Device device, out ExtendedMaterial[] materials)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromFile (string filename, MeshFlags options, Device device, out GraphicsStream adjacency, out ExtendedMaterial[] materials)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromFile (string filename, MeshFlags options, Device device, out GraphicsStream adjacency, out ExtendedMaterial[] materials, out EffectInstance[] effects)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromX (XFileData xofObjMesh, MeshFlags options, Device device, out EffectInstance[] effects)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromX (XFileData xofObjMesh, MeshFlags options, Device device, out GraphicsStream adjacency, out EffectInstance[] effects)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromX (XFileData xofObjMesh, MeshFlags options, Device device, out ExtendedMaterial[] materials, out EffectInstance[] effects)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromX (XFileData xofObjMesh, MeshFlags options, Device device)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromX (XFileData xofObjMesh, MeshFlags options, Device device, out GraphicsStream adjacency)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromX (XFileData xofObjMesh, MeshFlags options, Device device, out ExtendedMaterial[] materials)
		{
			throw new NotImplementedException ();
		}

		public static Mesh FromX (XFileData xofObjMesh, MeshFlags options, Device device, out GraphicsStream adjacency, out ExtendedMaterial[] materials, out EffectInstance[] effects)
		{
			throw new NotImplementedException ();
		}

		public static Mesh TessellateNPatches (Mesh mesh, GraphicsStream adjacencyIn, float numSegs, bool quadraticInterpNormals)
		{
			throw new NotImplementedException ();
		}

		public static Mesh TessellateNPatches (Mesh mesh, GraphicsStream adjacencyIn, float numSegs, bool quadraticInterpNormals, out GraphicsStream adjacencyOut)
		{
			throw new NotImplementedException ();
		}

		public static Mesh TessellateNPatches (Mesh mesh, int[] adjacencyIn, float numSegs, bool quadraticInterpNormals)
		{
			throw new NotImplementedException ();
		}

		public static Mesh TessellateNPatches (Mesh mesh, int[] adjacencyIn, float numSegs, bool quadraticInterpNormals, out GraphicsStream adjacencyOut)
		{
			throw new NotImplementedException ();
		}

		public void WeldVertices (WeldEpsilonsFlags flags, WeldEpsilons epsilons, int[] adjacencyIn, out GraphicsStream vertexRemap)
		{
			throw new NotImplementedException ();
		}

		public void WeldVertices (WeldEpsilonsFlags flags, WeldEpsilons epsilons, int[] adjacencyIn)
		{
			throw new NotImplementedException ();
		}

		public void WeldVertices (WeldEpsilonsFlags flags, WeldEpsilons epsilons, int[] adjacencyIn, out int[] adjacencyOut, out int[] faceRemap, out GraphicsStream vertexRemap)
		{
			throw new NotImplementedException ();
		}

		public void WeldVertices (WeldEpsilonsFlags flags, WeldEpsilons epsilons, GraphicsStream adjacencyIn, [Out] GraphicsStream adjacencyOut)
		{
			throw new NotImplementedException ();
		}

		public void WeldVertices (WeldEpsilonsFlags flags, WeldEpsilons epsilons, GraphicsStream adjacencyIn, GraphicsStream adjacencyOut, out int[] faceRemap, out GraphicsStream vertexRemap)
		{
			throw new NotImplementedException ();
		}

		public bool Intersect (Vector3 rayPos, Vector3 rayDir)
		{
			throw new NotImplementedException ();
		}

		public bool Intersect (Vector3 rayPos, Vector3 rayDir, out IntersectInformation[] allHits)
		{
			throw new NotImplementedException ();
		}

		public bool Intersect (Vector3 rayPos, Vector3 rayDir, out IntersectInformation closestHit)
		{
			throw new NotImplementedException ();
		}

		public bool Intersect (Vector3 rayPos, Vector3 rayDir, out IntersectInformation closestHit, out IntersectInformation[] allHits)
		{
			throw new NotImplementedException ();
		}
		
		public bool IntersectSubset (int attributeId, Vector3 rayPos, Vector3 rayDir)
		{
			throw new NotImplementedException ();
		}
		
		public bool IntersectSubset (int attributeId, Vector3 rayPos, Vector3 rayDir, out IntersectInformation[] allHits)
		{
			throw new NotImplementedException ();
		}
		
		public bool IntersectSubset (int attributeId, Vector3 rayPos, Vector3 rayDir, out IntersectInformation closestHit)
		{
			throw new NotImplementedException ();
		}
		
		public bool IntersectSubset (int attributeId, Vector3 rayPos, Vector3 rayDir, out IntersectInformation closestHit, out IntersectInformation[] allHits)
		{
			throw new NotImplementedException ();
		}

		public void ComputeTangent (int texStage, int tangentIndex, int binormIndex, int wrap)
		{
			throw new NotImplementedException ();
		}

		public void ComputeTangent (int texStage, int tangentIndex, int binormIndex, int wrap, GraphicsStream adjacency)
		{
			throw new NotImplementedException ();
		}

		public void ComputeTangent (int texStage, int tangentIndex, int binormIndex, int wrap, int[] adjacency)
		{
			throw new NotImplementedException ();
		}

		public static Mesh[] Split (Mesh mesh, int[] adjacencyIn, int maxSize, MeshFlags options)
		{
			throw new NotImplementedException ();
		}

		public static Mesh[] Split (Mesh mesh, int[] adjacencyIn, int maxSize, MeshFlags options, out GraphicsStream adjacencyArrayOut, out GraphicsStream faceRemapArrayOut, out GraphicsStream vertRemapArrayOut)
		{
			throw new NotImplementedException ();
		}

		public void Save (string filename, GraphicsStream adjacency, ExtendedMaterial[] materials, XFileFormat format)
		{
			throw new NotImplementedException ();
		}

		public void Save (string filename, GraphicsStream adjacency, ExtendedMaterial[] materials, EffectInstance[] effects, XFileFormat format)
		{
			throw new NotImplementedException ();
		}

		public void Save (string filename, int[] adjacency, ExtendedMaterial[] materials, XFileFormat format)
		{
			throw new NotImplementedException ();
		}

		public void Save (string filename, int[] adjacency, ExtendedMaterial[] materials, EffectInstance[] effects, XFileFormat format)
		{
			throw new NotImplementedException ();
		}

		public void Save (Stream stream, GraphicsStream adjacency, ExtendedMaterial[] materials, XFileFormat format)
		{
			throw new NotImplementedException ();
		}

		public void Save (Stream stream, GraphicsStream adjacency, ExtendedMaterial[] materials, EffectInstance[] effects, XFileFormat format)
		{
			throw new NotImplementedException ();
		}

		public void Save (Stream stream, int[] adjacency, ExtendedMaterial[] materials, XFileFormat format)
		{
			throw new NotImplementedException ();
		}

		public void Save (Stream stream, int[] adjacency, ExtendedMaterial[] materials, EffectInstance[] effects, XFileFormat format)
		{
			throw new NotImplementedException ();
		}

		public static IndexBuffer ConvertMeshSubsetToSingleStrip (Mesh mesh, int attributeIdentifier, MeshFlags indexBufferOptions, out int numIndices)
		{
			throw new NotImplementedException ();
		}

		public static IndexBuffer ConvertMeshSubsetToStrips (BaseMesh mesh, int attributeIdentifier, MeshFlags indexBufferOptions, out int numIndices, out GraphicsStream stripLengths, out int numStrips)
		{
			throw new NotImplementedException ();
		}

		public static AnimationRootFrame LoadHierarchyFromFile (string filename, MeshFlags options, Device device, AllocateHierarchy allocHierarchy, LoadUserData userDataLoader)
		{
			throw new NotImplementedException ();
		}

		public static AnimationRootFrame LoadHierarchy (Stream stream, MeshFlags options, Device device, AllocateHierarchy allocHierarchy, LoadUserData userDataLoader)
		{
			throw new NotImplementedException ();
		}

		public static AnimationRootFrame LoadHierarchy (Stream stream, int readBytes, MeshFlags options, Device device, AllocateHierarchy allocHierarchy, LoadUserData userDataLoader)
		{
			throw new NotImplementedException ();
		}

		public static void SaveHierarchyToFile (string filename, XFileFormat format, Frame frameRoot, AnimationController animationMixer, SaveUserData saveUserData)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void UpdateUnmanagedPointer (ID3DXMesh* pInterface)
		{
			throw new NotImplementedException ();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public new IntPtr GetObjectByValue (int uniqueKey)
		{
			throw new NotImplementedException ();
		}

	}
}
