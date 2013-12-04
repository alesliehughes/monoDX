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
	[Flags]
	public enum MeshFlags
	{
		SimplifyFace = 2,
		SimplifyVertex = 1,
		OptimizeDeviceIndependent = 4194304,
		OptimizeDoNotSplit = 536870912,
		OptimizeIgnoreVerts = 268435456,
		OptimizeStripeReorder = 134217728,
		OptimizeVertexCache = 67108864,
		OptimizeAttributeSort = 33554432,
		OptimizeCompact = 16777216,
		SoftwareProcessing = 98304,
		Dynamic = 2176,
		WriteOnly = 1088,
		Managed = 544,
		SystemMemory = 272,
		UseHardwareOnly = 8192,
		VbShare = 4096,
		IbSoftwareProcessing = 65536,
		IbDynamic = 2048,
		IbWriteOnly = 1024,
		IbManaged = 512,
		IbSystemMem = 256,
		VbSoftwareProcessing = 32768,
		VbDynamic = 128,
		VbWriteOnly = 64,
		VbManaged = 32,
		VbSystemMem = 16,
		NPatches = 16384,
		RtPatches = 8,
		Points = 4,
		DoNotClip = 2,
		Use32Bit = 1
	}
}


