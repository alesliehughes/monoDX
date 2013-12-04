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
	public enum TextureOperation
	{
		Lerp = 26,
		MultiplyAdd = 25,
		DotProduct3 = 24,
		BumpEnvironmentMapLuminance = 23,
		BumpEnvironmentMap = 22,
		ModulateInvColorAddAlpha = 21,
		ModulateInvAlphaAddColor = 20,
		ModulateColorAddAlpha = 19,
		ModulateAlphaAddColor = 18,
		PreModulate = 17,
		BlendCurrentAlpha = 16,
		BlendTextureAlphaPM = 15,
		BlendFactorAlpha = 14,
		BlendTextureAlpha = 13,
		BlendDiffuseAlpha = 12,
		AddSmooth = 11,
		Subtract = 10,
		AddSigned2X = 9,
		AddSigned = 8,
		Add = 7,
		Modulate4X = 6,
		Modulate2X = 5,
		Modulate = 4,
		SelectArg2 = 3,
		SelectArg1 = 2,
		Disable = 1
	}
}
