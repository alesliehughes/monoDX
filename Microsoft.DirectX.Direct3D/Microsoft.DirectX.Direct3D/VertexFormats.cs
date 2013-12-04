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
	public enum VertexFormats
	{
		PositionNormal = 18,
		LastBetaD3DColor = 32768,
		LastBetaUByte4 = 4096,
		Texture8 = 2048,
		Texture7 = 1792,
		Texture6 = 1536,
		Texture5 = 1280,
		Texture4 = 1024,
		Texture3 = 768,
		Texture2 = 512,
		Texture1 = 256,
		Texture0 = 0,
		TextureCountShift = 8,
		TextureCountMask = 3840,
		Specular = 128,
		Diffuse = 64,
		PointSize = 32,
		PositionW = 16386,
		PositionBlend5 = 14,
		PositionBlend4 = 12,
		PositionBlend3 = 10,
		PositionBlend2 = 8,
		PositionBlend1 = 6,
		Transformed = 4,
		Position = 2,
		PositionMask = 16398,
		None = 0,
		Normal = 16
	}
}
