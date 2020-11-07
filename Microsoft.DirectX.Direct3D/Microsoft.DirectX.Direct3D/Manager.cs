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
using System.Runtime.InteropServices;

namespace Microsoft.DirectX.Direct3D
{
	public sealed class Manager : MarshalByRefObject, IDisposable
	{
		internal static IntPtr _d3d9;

		[DllImport("monodx.dll", CallingConvention=CallingConvention.Cdecl)]
		internal static extern void d3d9_Create([Out] out IntPtr d3d9);

		[DllImport("monodx.dll", CallingConvention=CallingConvention.Cdecl)]
		internal static extern void d3d9_Release([In] IntPtr d3d9);

		[DllImport("monodx.dll", CallingConvention=CallingConvention.Cdecl)]
		internal static extern uint d3d9_GetAdapterCount([In] IntPtr d3d9);

		[DllImport("monodx.dll", CallingConvention=CallingConvention.Cdecl)]
		internal static extern int d3d9_GetAdapterCurrentDisplayMode([In] IntPtr d3d9, [In] uint adapter, [Out] out DisplayMode.D3DDISPLAYMODE mode);

		[DllImport("monodx.dll", CallingConvention=CallingConvention.Cdecl)]
		internal static extern uint d3d9_GetAdapterDisplayModeCount([In] IntPtr d3d9, [In] uint adapter);

		[DllImport("monodx.dll", CallingConvention=CallingConvention.Cdecl)]
		internal static extern void d3d9_GetAdapterDisplayMode([In] IntPtr d3d9, [In] uint adapter, [In] uint index, [Out] out DisplayMode.D3DDISPLAYMODE mode);

		[DllImport("monodx.dll", CallingConvention=CallingConvention.Cdecl)]
		internal static extern void d3d9_GetDeviceCaps([In] IntPtr d3d9, [In] uint adapter, [In] uint type, [Out] out Caps.D3DCAPS9 caps);

		internal static int GetAdapterDisplayModeCount(int adapter)
		{
			return (int)d3d9_GetAdapterDisplayModeCount(_d3d9, (uint)adapter);
		}

		internal static DisplayMode GetAdapterCurrentDisplayMode(int adapter)
		{
			Marshal.ThrowExceptionForHR(
				d3d9_GetAdapterCurrentDisplayMode(_d3d9, (uint)adapter, out var mode));
			return new DisplayMode(mode);
		}

		internal static DisplayMode GetAdapterDisplayMode(int adapter, int index)
		{
			d3d9_GetAdapterDisplayMode(_d3d9, (uint)adapter, (uint)index, out var mode);
			return new DisplayMode(mode);
		}

		public static AdapterListCollection Adapters {
			get => new AdapterListCollection((int)d3d9_GetAdapterCount(_d3d9));
		}

		static Manager ()
		{
			d3d9_Create(out _d3d9);
			if (_d3d9 == null) throw new NullReferenceException();
		}

		public void Dispose()
		{
			d3d9_Release(_d3d9);
		}

		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}

		public static bool operator == (Manager left, Manager right)
		{
			throw new NotImplementedException ();
		}

		public static bool operator != (Manager left, Manager right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}

		public static bool CheckDeviceType (int adapter, DeviceType checkType, Format displayFormat, Format backBufferFormat, bool windowed)
		{
			throw new NotImplementedException ();
		}

		public static bool CheckDeviceType (int adapter, DeviceType checkType, Format displayFormat, Format backBufferFormat, bool windowed, out int result)
		{
			throw new NotImplementedException ();
		}

		public static bool CheckDeviceFormat (int adapter, DeviceType deviceType, Format adapterFormat, Usage usage, ResourceType resourceType, DepthFormat checkFormat)
		{
			throw new NotImplementedException ();
		}

		public static bool CheckDeviceFormat (int adapter, DeviceType deviceType, Format adapterFormat, Usage usage, ResourceType resourceType, DepthFormat checkFormat, out int result)
		{
			throw new NotImplementedException ();
		}

		public static bool CheckDeviceFormat (int adapter, DeviceType deviceType, Format adapterFormat, Usage usage, ResourceType resourceType, Format checkFormat)
		{
			throw new NotImplementedException ();
		}

		public static bool CheckDeviceFormat (int adapter, DeviceType deviceType, Format adapterFormat, Usage usage, ResourceType resourceType, Format checkFormat, out int result)
		{
			throw new NotImplementedException ();
		}

		public static bool CheckDeviceMultiSampleType (int adapter, DeviceType deviceType, Format surfaceFormat, bool windowed, MultiSampleType multiSampleType, out int result, out int qualityLevels)
		{
			throw new NotImplementedException ();
		}

		public static bool CheckDeviceMultiSampleType (int adapter, DeviceType deviceType, Format surfaceFormat, bool windowed, MultiSampleType multiSampleType)
		{
			throw new NotImplementedException ();
		}

		public static bool CheckDepthStencilMatch (int adapter, DeviceType deviceType, Format adapterFormat, Format renderTargetFormat, DepthFormat depthStencilFormat, out int result)
		{
			throw new NotImplementedException ();
		}

		public static bool CheckDepthStencilMatch (int adapter, DeviceType deviceType, Format adapterFormat, Format renderTargetFormat, DepthFormat depthStencilFormat)
		{
			throw new NotImplementedException ();
		}

		public static bool CheckDeviceFormatConversion (int adapter, DeviceType deviceType, Format sourceFormat, Format targetFormat, out int result)
		{
			throw new NotImplementedException ();
		}

		public static bool CheckDeviceFormatConversion (int adapter, DeviceType deviceType, Format sourceFormat, Format targetFormat)
		{
			throw new NotImplementedException ();
		}

		public static Caps GetDeviceCaps (int adapter, DeviceType deviceType)
		{
			d3d9_GetDeviceCaps(_d3d9, (uint)adapter, (uint)deviceType, out var caps);
			return new Caps(caps);
		}

		public static IntPtr GetAdapterMonitor (int adapter)
		{
			throw new NotImplementedException ();
		}

		public static bool DisableD3DSpy ()
		{
			throw new NotImplementedException ();
		}

		public static bool GenerateD3DSpyBreak ()
		{
			throw new NotImplementedException ();
		}
	}
}

