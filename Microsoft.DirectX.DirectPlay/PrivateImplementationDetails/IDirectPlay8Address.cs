/*
 * The MIT License (MIT)
 *
 * Copyright (c) 2018 Alistair Leslie-Hughes
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
using Microsoft.VisualC;
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace DirectX.PrivateImplementationDetails
{
	[Guid("83783300-4063-4c8a-9db3-82830a7feb31")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	[CLSCompliant(false)]
	public interface IDirectPlay8Address
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void BuildFromURLW ([In] ref ushort pwszSourceURL);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void BuildFromURLA ([In] ref sbyte pszSourceURL);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Duplicate ([MarshalAs (UnmanagedType.Interface)] out IDirectPlay8Address ppdpaNewAddress);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetEqual ([In] [MarshalAs (UnmanagedType.Interface)] IDirectPlay8Address pdpaAddress);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void IsEqual ([In] [MarshalAs (UnmanagedType.Interface)] IDirectPlay8Address pdpaAddress);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Clear ();

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetURLW (out ushort pwszURL, out uint pdwNumChars);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetURLA (out sbyte pszURL, out uint pdwNumChars);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetSP (out GUID pguidSP);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetUserData ([Out] IntPtr pvUserData, out uint pdwBufferSize);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetSP ([In] ref GUID pguidSP);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetUserData ([In] IntPtr pvUserData, [In] uint dwDataSize);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetNumComponents (out uint pdwNumComponents);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetComponentByName ([In] ref ushort pwszName, [Out] IntPtr pvBuffer, out uint pdwBufferSize, out uint pdwDataType);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetComponentByIndex ([In] uint dwComponentID, out ushort pwszName, out uint pdwNameLen, [Out] IntPtr pvBuffer, out uint pdwBufferSize, ref uint pdwDataType);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddComponent ([In] ref ushort pwszName, [In] IntPtr lpvData, [In] uint dwDataSize, [In] uint dwDataType);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetDevice (out GUID pDevGuid);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetDevice (ref GUID devGuid);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void BuildFromDirectPlay4Address ([In] IntPtr pvAddress, [In] uint dwDataSize);
	}
}
