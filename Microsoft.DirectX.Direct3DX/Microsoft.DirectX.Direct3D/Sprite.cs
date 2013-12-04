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
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Drawing;
using Microsoft.DirectX.PrivateImplementationDetails;

namespace Microsoft.DirectX.Direct3D
{
	public sealed class Sprite : MarshalByRefObject, IDisposable
	{
		/*public event EventHandler Disposing {
			[MethodImpl(32)]
			add {
				throw new NotImplementedException ();
			}
			[MethodImpl(32)]
			remove {
				throw new NotImplementedException ();
			}
		}

		public event EventHandler Reset {
			[MethodImpl(32)]
			add {
				throw new NotImplementedException ();
			}
			[MethodImpl(32)]
			remove {
				throw new NotImplementedException ();
			}
		}

		public event EventHandler Lost {
			[MethodImpl(32)]
			add {
				throw new NotImplementedException ();
			}
			[MethodImpl(32)]
			remove {
				throw new NotImplementedException ();
			}
		}*/

		[CLSCompliant(false)]
		public unsafe ID3DXSprite* UnmanagedComPointer {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool Disposed {
			get {
				throw new NotImplementedException ();
			}
		}

		public Matrix Transform {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public Device Device {
			get {
				throw new NotImplementedException ();
			}
		}

		static Sprite ()
		{

		}

		[CLSCompliant(false)]
		public unsafe Sprite (ID3DXSprite* pUnk)
		{
			throw new NotImplementedException ();
		}

		public unsafe Sprite (IntPtr unmanagedObject)
		{
			throw new NotImplementedException ();
		}

		public Sprite (Device device)
		{
			throw new NotImplementedException ();
		}

		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}

		public static bool operator == (Sprite left, Sprite right)
		{
			throw new NotImplementedException ();
		}

		public static bool operator != (Sprite left, Sprite right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}

		public void Begin (SpriteFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void Flush ()
		{
			throw new NotImplementedException ();
		}

		public void End ()
		{
			throw new NotImplementedException ();
		}

		public void Draw (Texture srcTexture, Rectangle srcRectangle, Vector3 center, Vector3 position, Color color)
		{
			throw new NotImplementedException ();
		}

		public void Draw (Texture srcTexture, Vector3 center, Vector3 position, int color)
		{
			throw new NotImplementedException ();
		}

		public void Draw (Texture srcTexture, Rectangle srcRectangle, Vector3 center, Vector3 position, int color)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void Draw (Texture srcTexture, Rectangle* srcRectangle, Vector3 center, Vector3 position, int color)
		{
			throw new NotImplementedException ();
		}

		public void Draw2D (Texture srcTexture, PointF rotationCenter, float rotationAngle, PointF position, Color color)
		{
			throw new NotImplementedException ();
		}

		public void Draw2D (Texture srcTexture, PointF rotationCenter, float rotationAngle, PointF position, int color)
		{
			throw new NotImplementedException ();
		}

		public void Draw2D (Texture srcTexture, Rectangle srcRectangle, SizeF destinationSize, PointF rotationCenter, float rotationAngle, PointF position, Color color)
		{
			throw new NotImplementedException ();
		}

		public unsafe void Draw2D (Texture srcTexture, Rectangle srcRectangle, SizeF destinationSize, PointF rotationCenter, float rotationAngle, PointF position, int color)
		{
			throw new NotImplementedException ();
		}

		public void Draw2D (Texture srcTexture, Rectangle srcRectangle, SizeF destinationSize, PointF position, Color color)
		{
			throw new NotImplementedException ();
		}

		public void Draw2D (Texture srcTexture, Rectangle srcRectangle, SizeF destinationSize, PointF position, int color)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void Draw2D (Texture srcTexture, Rectangle* srcRectangle, SizeF* destinationSize, PointF* center, float rotationAngle, PointF position, int color)
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

		public void SetWorldViewRH (Matrix world, Matrix view)
		{
			throw new NotImplementedException ();
		}

		public void SetWorldViewLH (Matrix world, Matrix view)
		{
			throw new NotImplementedException ();
		}

		public void Dispose ()
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void UpdateUnmanagedPointer (ID3DXSprite* pInterface)
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
