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
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace Microsoft.DirectX.Direct3D
{
	public sealed class SwapChain : MarshalByRefObject, IDisposable
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
		public unsafe IDirect3DSwapChain9* UnmanagedComPointer {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool Disposed {
			get {
				throw new NotImplementedException ();
			}
		}

		public DisplayMode DisplayMode {
			get {
				throw new NotImplementedException ();
			}
		}

		public RasterStatus RasterStatus {
			get {
				throw new NotImplementedException ();
			}
		}

		public PresentParameters PresentParameters {
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
		
		public static bool operator == (SwapChain left, SwapChain right)
		{
			throw new NotImplementedException ();
		}

		public static bool operator != (SwapChain left, SwapChain right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe SwapChain (IDirect3DSwapChain9* pUnk)
		{
			throw new NotImplementedException ();
		}

		public unsafe SwapChain (IntPtr unmanagedObject)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe SwapChain (IDirect3DSwapChain9* lp, Device device)
		{
			throw new NotImplementedException ();
		}

		public SwapChain (Device device, PresentParameters presentationParameters)
		{
			throw new NotImplementedException ();
		}

		public void Dispose ()
		{
		
		}
	
		public void Present (Rectangle rectPresent, IntPtr overrideWindowHandle, Present flags, bool sourceRectangle)
		{
			throw new NotImplementedException ();
		}

		public void Present (IntPtr overrideWindowHandle, Present flags)
		{
			throw new NotImplementedException ();
		}

		public void Present (Rectangle sourceRectangle, Rectangle destRectangle, IntPtr overrideWindowHandle, Present flags)
		{
			throw new NotImplementedException ();
		}

		public void Present (Rectangle rectPresent, IntPtr overrideWindowHandle, bool sourceRectangle)
		{
			throw new NotImplementedException ();
		}

		public void Present (IntPtr overrideWindowHandle)
		{
			throw new NotImplementedException ();
		}

		public void Present (Rectangle sourceRectangle, Rectangle destRectangle, IntPtr overrideWindowHandle)
		{
			throw new NotImplementedException ();
		}

		public void Present (Rectangle rectPresent, Present flags, bool sourceRectangle)
		{
			throw new NotImplementedException ();
		}

		public void Present (Rectangle rectPresent, Control overrideWindow, Present flags, bool sourceRectangle)
		{
			throw new NotImplementedException ();
		}

		public void Present (Control overrideWindow, Present flags)
		{
			throw new NotImplementedException ();
		}

		public void Present (Present flags)
		{
			throw new NotImplementedException ();
		}

		public void Present (Rectangle sourceRectangle, Rectangle destRectangle, Control overrideWindow, Present flags)
		{
			throw new NotImplementedException ();
		}

		public void Present (Rectangle rectPresent, bool sourceRectangle)
		{
			throw new NotImplementedException ();
		}

		public void Present (Rectangle rectPresent, Control overrideWindow, bool sourceRectangle)
		{
			throw new NotImplementedException ();
		}

		public void Present (Control overrideWindow)
		{
			throw new NotImplementedException ();
		}

		public void Present ()
		{
			throw new NotImplementedException ();
		}

		public void Present (Rectangle sourceRectangle, Rectangle destRectangle, Control overrideWindow)
		{
			throw new NotImplementedException ();
		}

		public Surface GetBackBuffer (int backBuffer, BackBufferType typeBuffer)
		{
			throw new NotImplementedException ();
		}

		public void GetFrontBufferData (Surface frontBuffer)
		{
			throw new NotImplementedException ();
		}
	
		[EditorBrowsable]
		public IntPtr GetObjectByValue (int uniqueKey)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void UpdateUnmanagedPointer (IDirect3DSwapChain9* pInterface)
		{
			throw new NotImplementedException ();
		}

	}
}


