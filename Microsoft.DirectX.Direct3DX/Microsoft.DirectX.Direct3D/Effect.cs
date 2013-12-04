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
using Microsoft.DirectX.PrivateImplementationDetails;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.DirectX.Direct3D
{
	public sealed class Effect : BaseEffect, IDisposable
	{
		public new event EventHandler Disposing {
			add {
				throw new NotImplementedException ();
			}
			remove {
				throw new NotImplementedException ();
			}
		}

		public event EventHandler Reset {
	
			add {
				throw new NotImplementedException ();
			}
		
			remove {
				throw new NotImplementedException ();
			}
		}

		public event EventHandler Lost {
		
			add {
				throw new NotImplementedException ();
			}
	
			remove {
				throw new NotImplementedException ();
			}
		}

		[CLSCompliant(false)]
		public unsafe new ID3DXEffect* UnmanagedComPointer {
			get {
				throw new NotImplementedException ();
			}
		}

		public new bool Disposed {

			get {
				throw new NotImplementedException ();
			}
		}

		public EffectStateManager StateManager {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public EffectHandle Technique {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public EffectPool Pool {
			get {
				throw new NotImplementedException ();
			}
		}

		public Device Device {
			get {
				throw new NotImplementedException ();
			}
		}
		
		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}

		public static bool operator == (Effect left, Effect right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (Effect left, Effect right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}

		public new void Dispose ()
		{
			throw new NotImplementedException ();
		}

		public Effect Clone (Device dev)
		{
			throw new NotImplementedException ();
		}

		public void OnLostDevice ()
		{
			throw new NotImplementedException ();
		}

		public void OnResetDevice ()
		{
			throw new NotImplementedException ();
		}

		public void ValidateTechnique (EffectHandle technique)
		{
			
		}
		
		public bool IsTechniqueValid (EffectHandle technique)
		{
			throw new NotImplementedException ();
		}
		
		public bool IsTechniqueValid (EffectHandle technique, out int returnValue)
		{
			throw new NotImplementedException ();
		}

		public EffectHandle FindNextValidTechnique (EffectHandle technique)
		{
			throw new NotImplementedException ();
		}

		public int Begin (FX flags)
		{
			throw new NotImplementedException ();
		}

		public void End ()
		{
			throw new NotImplementedException ();
		}

		public void BeginPass (int passNumber)
		{
			throw new NotImplementedException ();
		}

		public void EndPass ()
		{
			throw new NotImplementedException ();
		}

		public void CommitChanges ()
		{
			throw new NotImplementedException ();
		}
	
		public bool IsParameterUsed (EffectHandle parameter, EffectHandle technique)
		{
			throw new NotImplementedException ();
		}

		public static Effect FromFile (Device device, string sourceDataFile, Include includeFile, string skipConstants, ShaderFlags flags, EffectPool pool)
		{
			throw new NotImplementedException ();
		}

		public static Effect FromFile (Device device, string sourceDataFile, Include includeFile, string skipConstants, ShaderFlags flags, EffectPool pool, out string compilationErrors)
		{
			throw new NotImplementedException ();
		}

		public static Effect FromFile (Device device, string sourceDataFile, Macro[] preprocessorDefines, Include includeFile, string skipConstants, ShaderFlags flags, EffectPool pool, out string compilationErrors)
		{
			throw new NotImplementedException ();
		}

		public static Effect FromString (Device device, string sourceData, Include includeFile, string skipConstants, ShaderFlags flags, EffectPool pool)
		{
			throw new NotImplementedException ();
		}

		public static Effect FromString (Device device, string sourceData, Include includeFile, string skipConstants, ShaderFlags flags, EffectPool pool, out string compilationErrors)
		{
			throw new NotImplementedException ();
		}

		public static Effect FromString (Device device, string sourceData, Macro[] preprocessorDefines, Include includeFile, string skipConstants, ShaderFlags flags, EffectPool pool, out string compilationErrors)
		{
			throw new NotImplementedException ();
		}

		public static Effect FromStream (Device device, Stream data, Include includeFile, string skipConstants, ShaderFlags flags, EffectPool pool)
		{
			throw new NotImplementedException ();
		}

		public static Effect FromStream (Device device, Stream data, Include includeFile, string skipConstants, ShaderFlags flags, EffectPool pool, out string compilationErrors)
		{
			throw new NotImplementedException ();
		}

		public static Effect FromStream (Device device, Stream data, Macro[] preprocessorDefines, Include includeFile, string skipConstants, ShaderFlags flags, EffectPool pool, out string compilationErrors)
		{
			throw new NotImplementedException ();
		}

		public EffectHandle EndParameterBlock ()
		{
			throw new NotImplementedException ();
		}

		public void ApplyParameterBlock (EffectHandle parameterBlock)
		{
			throw new NotImplementedException ();
		}

		public void DeleteParameterBlock (EffectHandle parameterBlock)
		{
			throw new NotImplementedException ();
		}

		public void SetRawValue (EffectHandle parameter, GraphicsStream data, int byteOffset)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void SetRawValue (EffectHandle parameter, void* data, int byteOffset, int dataSize)
		{
			throw new NotImplementedException ();
		}

		public void SetArrayRange (EffectHandle parameter, int start, int end)
		{
			throw new NotImplementedException ();
		}

		public string Disassemble ([MarshalAs(4)] bool enableColorCode)
		{
			return Effect.Disassemble (this, enableColorCode);
		}

		public static string Disassemble (Effect effect, bool enableColorCode)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe Effect (ID3DXEffect* pInterop) : base(null)
		{
			throw new NotImplementedException ();
		}

		public unsafe Effect (IntPtr unmanagedObject) : base(null)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe Effect (ID3DXEffect* pData, Device device) : base((ID3DXBaseEffect*)pData)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void UpdateUnmanagedPointer (ID3DXEffect* pInterface)
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


