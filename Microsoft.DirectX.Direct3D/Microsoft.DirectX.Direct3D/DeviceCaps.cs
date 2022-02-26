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
	public struct DeviceCaps
	{
		internal uint devcaps;
		internal uint devcaps2;

		internal DeviceCaps(uint devcaps, uint devcaps2)
		{
			this.devcaps = devcaps;
			this.devcaps2 = devcaps2;
		}

		public bool VertexElementScanSharesStreamOffset {
			get {
				return (devcaps2 & 0x40) != 0;
			}
		}

		public bool CanStretchRectangleFromTextures {
			get {
				return (devcaps2 & 0x10) != 0;
			}
		}

		public bool SupportsAdaptiveTessellateNPatch {
			get {
				return (devcaps2 & 0x8) != 0;
			}
		}

		public bool SupportsAdaptiveTessellateRtPatch {
			get {
				return (devcaps2 & 0x4) != 0;
			}
		}

		public bool SupportsDMapNPatch {
			get {
				return (devcaps2 & 0x2) != 0;
			}
		}

		public bool SupportsStreamOffset {
			get {
				return (devcaps2 & 0x1) != 0;
			}
		}

		public bool SupportsPreSampledDMapNPatch {
			get {
				return (devcaps2 & 0x20) != 0;
			}
		}

		public bool SupportsNPatches {
			get {
				return (devcaps & 0x1000000) != 0;
			}
		}

		public bool SupportsRtPatchHandleZero {
			get {
				return (devcaps & 0x800000) != 0;
			}
		}

		public bool SupportsRtPatches {
			get {
				return (devcaps & 0x400000) != 0;
			}
		}

		public bool SupportsQuinticRtPatches {
			get {
				return (devcaps & 0x200000) != 0;
			}
		}

		public bool SupportsPureDevice {
			get {
				return (devcaps & 0x100000) != 0;
			}
		}

		public bool SupportsHardwareRasterization {
			get {
				return (devcaps & 0x80000) != 0;
			}
		}

		public bool CanDrawSystemToNonLocal {
			get {
				return (devcaps & 0x20000) != 0;
			}
		}

		public bool SupportsHardwareTransformAndLight {
			get {
				return (devcaps & 0x10000) != 0;
			}
		}

		public bool SupportsDrawPrimitives2Ex {
			get {
				return (devcaps & 0x8000) != 0;
			}
		}

		public bool SupportsSeparateTextureMemories {
			get {
				return (devcaps & 0x4000) != 0;
			}
		}

		public bool SupportsDrawPrimitives2 {
			get {
				return (devcaps & 0x2000) != 0;
			}
		}

		public bool SupportsTextureNonLocalVideoMemory {
			get {
				return (devcaps & 0x1000) != 0;
			}
		}

		public bool CanRenderAfterFlip {
			get {
				return (devcaps & 0x800) != 0;
			}
		}

		public bool SupportsDrawPrimitivesTransformedVertex {
			get {
				return (devcaps & 0x400) != 0;
			}
		}

		public bool SupportsTextureVideoMemory {
			get {
				return (devcaps & 0x200) != 0;
			}
		}

		public bool SupportsTextureSystemMemory {
			get {
				return (devcaps & 0x100) != 0;
			}
		}

		public bool SupportsTransformedVertexVideoMemory {
			get {
				return (devcaps & 0x80) != 0;
			}
		}

		public bool SupportsTransformedVertexSystemMemory {
			get {
				return (devcaps & 0x40) != 0;
			}
		}

		public bool SupportsExecuteVideoMemory {
			get {
				return (devcaps & 0x20) != 0;
			}
		}

		public bool SupportsExecuteSystemMemory {
			get {
				return (devcaps & 0x10) != 0;
			}
		}

		public override string ToString ()
		{
			throw new NotImplementedException ();
		}
	}
}
