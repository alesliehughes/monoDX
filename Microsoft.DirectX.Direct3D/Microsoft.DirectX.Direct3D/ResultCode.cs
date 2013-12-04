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

namespace Microsoft.DirectX.Direct3D
{
	public enum ResultCode
	{
		WrongTextureFormat = -2005530600,
		UnsupportedColorOperation = -2005530599,
		UnsupportedColorArgument = -2005530598,
		UnsupportedAlphaOperation = -2005530597,
		UnsupportedAlphaArgument = -2005530596,
		TooManyOperations = -2005530595,
		ConflictingTextureFilter = -2005530594,
		UnsupportedFactorValue = -2005530593,
		UnsupportedTextureFilter = -2005530590,
		DeviceLost = -2005530520,
		DeviceNotReset = -2005530519,
		NotAvailable = -2005530518,
		InvalidDevice = -2005530517,
		InvalidCall = -2005530516,
		Success = 0,
	}
}
