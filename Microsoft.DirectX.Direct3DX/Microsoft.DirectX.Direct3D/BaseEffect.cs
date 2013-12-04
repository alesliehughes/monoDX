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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.DirectX.Direct3D
{
	public class BaseEffect : MarshalByRefObject, IDisposable
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
		public unsafe ID3DXBaseEffect* UnmanagedComPointer {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool Disposed {

			get {
				throw new NotImplementedException ();
			}
		}

		public EffectDescription Description {
			get {
				throw new NotImplementedException ();
			}
		}

		static BaseEffect ()
		{
			throw new NotImplementedException ();
		}
		
		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator == (BaseEffect left, BaseEffect right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (BaseEffect left, BaseEffect right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}

		public void Dispose ()
		{
			throw new NotImplementedException ();
		}

		public ParameterDescription GetParameterDescription (EffectHandle parameter)
		{
			throw new NotImplementedException ();
		}

		public TechniqueDescription GetTechniqueDescription (EffectHandle technique)
		{
			throw new NotImplementedException ();
		}

		public PassDescription GetPassDescription (EffectHandle pass)
		{
			throw new NotImplementedException ();
		}

		public FunctionDescription GetFunctionDescription (EffectHandle shader)
		{
			throw new NotImplementedException ();
		}

		public EffectHandle GetParameter (EffectHandle constant, string name)
		{
			throw new NotImplementedException ();
		}

		public EffectHandle GetParameter (EffectHandle constant, int index)
		{
			throw new NotImplementedException ();
		}

		public EffectHandle GetParameterBySemantic (EffectHandle constant, string name)
		{
			throw new NotImplementedException ();
		}

		public EffectHandle GetParameterElement (EffectHandle constant, int index)
		{
			throw new NotImplementedException ();
		}

		public EffectHandle GetTechnique (string name)
		{
			throw new NotImplementedException ();
		}

		public EffectHandle GetTechnique (int index)
		{
			throw new NotImplementedException ();
		}

		public EffectHandle GetPass (EffectHandle technique, string name)
		{
			throw new NotImplementedException ();
		}

		public EffectHandle GetPass (EffectHandle technique, int index)
		{
			throw new NotImplementedException ();
		}

		public EffectHandle GetFunction (string name)
		{
			throw new NotImplementedException ();
		}

		public EffectHandle GetFunction (int index)
		{
			throw new NotImplementedException ();
		}

		public EffectHandle GetAnnotation (EffectHandle technique, string name)
		{
			throw new NotImplementedException ();
		}

		public EffectHandle GetAnnotation (EffectHandle technique, int index)
		{
			throw new NotImplementedException ();
		}

		public void SetValue (EffectHandle parameter, BaseTexture texture)
		{
			throw new NotImplementedException ();
		}

		public void SetValue (EffectHandle parameter, string str)
		{
			throw new NotImplementedException ();
		}

		public void SetValue (EffectHandle parameter, Matrix[] matrix)
		{
			throw new NotImplementedException ();
		}

		public void SetValue (EffectHandle parameter, Matrix matrix)
		{
			throw new NotImplementedException ();
		}

		public void SetValue (EffectHandle parameter, ColorValue[] color)
		{
			throw new NotImplementedException ();
		}

		public void SetValue (EffectHandle parameter, ColorValue color)
		{
			throw new NotImplementedException ();
		}

		public void SetValue (EffectHandle parameter, Vector4[] vector)
		{
			throw new NotImplementedException ();
		}

		public void SetValue (EffectHandle parameter, Vector4 vector)
		{
			throw new NotImplementedException ();
		}

		public void SetValue (EffectHandle parameter, float[] f)
		{
			throw new NotImplementedException ();
		}

		public void SetValue (EffectHandle parameter, float f)
		{
			throw new NotImplementedException ();
		}

		public void SetValue (EffectHandle parameter, int[] n)
		{
			throw new NotImplementedException ();
		}

		public void SetValue (EffectHandle parameter, int n)
		{
			throw new NotImplementedException ();
		}

		public void SetValue (EffectHandle parameter, bool[] b)
		{
			throw new NotImplementedException ();
		}

		public void SetValue (EffectHandle parameter, [MarshalAs(4)] bool b)
		{
			throw new NotImplementedException ();
		}

		public void SetValue (EffectHandle parameter, GraphicsStream data)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void SetValue (EffectHandle parameter, void* data, int dataSize)
		{
			throw new NotImplementedException ();
		}

		public void SetValueTranspose (EffectHandle parameter, Matrix[] matrix)
		{
			throw new NotImplementedException ();
		}

		public void SetValueTranspose (EffectHandle parameter, Matrix matrix)
		{
			throw new NotImplementedException ();
		}

		public GraphicsStream GetValue (EffectHandle parameter, int numberBytes)
		{
			throw new NotImplementedException ();
		}
		
		public bool GetValueBoolean (EffectHandle parameter)
		{
			throw new NotImplementedException ();
		}

		public bool[] GetValueBooleanArray (EffectHandle parameter, int count)
		{
			throw new NotImplementedException ();
		}

		public int GetValueInteger (EffectHandle parameter)
		{
			throw new NotImplementedException ();
		}

		public int[] GetValueIntegerArray (EffectHandle parameter, int count)
		{
			throw new NotImplementedException ();
		}

		public float GetValueFloat (EffectHandle parameter)
		{
			throw new NotImplementedException ();
		}

		public float[] GetValueFloatArray (EffectHandle parameter, int count)
		{
			throw new NotImplementedException ();
		}

		public Vector4 GetValueVector (EffectHandle parameter)
		{
			throw new NotImplementedException ();
		}

		public Vector4[] GetValueVectorArray (EffectHandle parameter, int count)
		{
			throw new NotImplementedException ();
		}

		public ColorValue GetValueColor (EffectHandle parameter)
		{
			throw new NotImplementedException ();
		}

		public ColorValue[] GetValueColorArray (EffectHandle parameter, int count)
		{
			throw new NotImplementedException ();
		}

		public Matrix GetValueMatrix (EffectHandle parameter)
		{
			throw new NotImplementedException ();
		}

		public Matrix[] GetValueMatrixArray (EffectHandle parameter, int count)
		{
			throw new NotImplementedException ();
		}

		public Matrix GetValueMatrixTranspose (EffectHandle parameter)
		{
			throw new NotImplementedException ();
		}

		public Matrix[] GetValueMatrixTransposeArray (EffectHandle parameter, int count)
		{
			throw new NotImplementedException ();
		}

		public string GetValueString (EffectHandle parameter)
		{
			throw new NotImplementedException ();
		}

		public Texture GetValueTexture (EffectHandle parameter)
		{
			throw new NotImplementedException ();
		}

		public PixelShader GetValuePixelShader (EffectHandle parameter)
		{
			throw new NotImplementedException ();
		}

		public VertexShader GetValueVertexShader (EffectHandle parameter)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void UpdateUnmanagedPointer (ID3DXBaseEffect* pInterface)
		{
			throw new NotImplementedException ();
		}

		[EditorBrowsable]
		public IntPtr GetObjectByValue (int uniqueKey)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe BaseEffect (ID3DXBaseEffect* pUnk)
		{
			throw new NotImplementedException ();
		}

		public unsafe BaseEffect (IntPtr unmanagedObject)
		{
			throw new NotImplementedException ();
		}

	}
}


