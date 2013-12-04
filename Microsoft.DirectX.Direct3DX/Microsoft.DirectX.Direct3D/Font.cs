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
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.DirectX.PrivateImplementationDetails;

namespace Microsoft.DirectX.Direct3D
{
	public class Font : IDisposable
	{
		public event EventHandler Disposing {
			[MethodImpl(MethodImplOptions.Synchronized)]
			add {
				throw new NotImplementedException ();
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove {
				throw new NotImplementedException ();
			}
		}

		public event EventHandler Reset {
			[MethodImpl(MethodImplOptions.Synchronized)]
			add {
				throw new NotImplementedException ();
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove {
				throw new NotImplementedException ();
			}
		}

		public event EventHandler Lost {
			[MethodImpl(MethodImplOptions.Synchronized)]
			add {
				throw new NotImplementedException ();
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove {
				throw new NotImplementedException ();
			}
		}
		
		[CLSCompliant(false)]
		public unsafe ID3DXFont* UnmanagedComPointer {
			get {
				throw new NotImplementedException ();
			}
		}
		
		public bool Disposed {
			get {
				throw new NotImplementedException ();
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual IntPtr NativePointer {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool IsDisposed {
			get {
				throw new NotImplementedException ();
			}
		}

		public IntPtr DeviceContext {
			get {
				throw new NotImplementedException ();
			}
		}

		public FontDescription Description {
			get {
				throw new NotImplementedException ();
			}
		}

		public Device Device {
			get {
				throw new NotImplementedException ();
			}
		}
		
		public static bool operator == (Font left, Font right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (Font left, Font right)
		{
			throw new NotImplementedException ();
		}

		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}
		
		public int DrawText (Sprite sprite, string text, int x, int y, Color color)
		{
			throw new NotImplementedException ();
		}

		public int DrawText (Sprite sprite, string text, int x, int y, int color)
		{
			throw new NotImplementedException ();
		}

		public int DrawText (Sprite sprite, string text, Point pos, Color color)
		{
			throw new NotImplementedException ();
		}

		public int DrawText (Sprite sprite, string text, Point pos, int color)
		{
			throw new NotImplementedException ();
		}

		public int DrawText (Sprite sprite, string text, Rectangle rect, DrawTextFormat format, Color color)
		{
			throw new NotImplementedException ();
		}

		public  int DrawText (Sprite sprite, string text, Rectangle rect, DrawTextFormat format, int color)
		{
			throw new NotImplementedException ();
		}
		
		public Font (IntPtr pInterface)
		{
			throw new NotImplementedException ();
		}

		public Font (Device device, Font font)
		{
			throw new NotImplementedException ();
		}

		public Font (Device device, FontDescription description)
		{
			throw new NotImplementedException ();
		}

		public Font (Device device, int height, int width, FontWeight weight, int miplevels, bool italic, CharacterSet charset, Precision outputPrecision, FontQuality quality, PitchAndFamily pitchFamily, string faceName)
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

		public int DrawString (Sprite sprite, string text, int x, int y, Color color)
		{
			throw new NotImplementedException ();
		}

		public int DrawString (Sprite sprite, string text, int x, int y, int color)
		{
			throw new NotImplementedException ();
		}

		public int DrawString (Sprite sprite, string text, Point? position, Color color)
		{
			throw new NotImplementedException ();
		}

		public int DrawString (Sprite sprite, string text, Point? position, int color)
		{
			throw new NotImplementedException ();
		}

		public int DrawString (Sprite sprite, string text, Rectangle? rect, DrawStringFormat format, Color color)
		{
			throw new NotImplementedException ();
		}

		public int DrawString (Sprite sprite, string text, Rectangle? rect, DrawStringFormat format, int color)
		{
			throw new NotImplementedException ();
		}

		public Rectangle MeasureString (Sprite sprite, string text, DrawStringFormat format, Color color)
		{
			throw new NotImplementedException ();
		}

		public Rectangle MeasureString (Sprite sprite, string text, DrawStringFormat format, int color)
		{
			throw new NotImplementedException ();
		}

		public void PreloadCharacters (int first, int last)
		{
			throw new NotImplementedException ();
		}

		public void PreloadGlyphs (int first, int last)
		{
			throw new NotImplementedException ();
		}

		public void PreloadText (string text)
		{
			throw new NotImplementedException ();
		}

		public Texture GetGlyphData (int glyph)
		{
			throw new NotImplementedException ();
		}

		protected void raise_Lost (object value0, EventArgs value1)
		{
			throw new NotImplementedException ();
		}

		protected void raise_Reset (object value0, EventArgs value1)
		{
			throw new NotImplementedException ();
		}

		protected void raise_Disposing (object value0, EventArgs value1)
		{
			throw new NotImplementedException ();
		}
		
		public override string ToString ()
		{
			throw new NotImplementedException ();
		}
		
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void UpdateNativePointer (IntPtr pInterface)
		{
			throw new NotImplementedException ();
		}
		
		protected virtual void Dispose (bool flag)
		{
			throw new NotImplementedException ();
		}

		public void Dispose ()
		{
			throw new NotImplementedException ();
		}

	}
}
