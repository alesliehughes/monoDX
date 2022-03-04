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
	public struct Caps
	{
		[StructLayout(LayoutKind.Sequential)]
		internal struct D3DVSHADERCAPS2_0
		{
  			public uint Caps;
  			public int DynamicFlowControlDepth;
  			public int NumTemps;
  			public int StaticFlowControlDepth;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct D3DPSHADERCAPS2_0
		{
  			public uint Caps;
  			public int DynamicFlowControlDepth;
  			public int NumTemps;
  			public int StaticFlowControlDepth;
  			public int NumInstructionSlots;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct D3DCAPS9
		{
			public uint DeviceType;
			public uint AdapterOrdinal;
			public uint Caps;
			public uint Caps2;
			public uint Caps3;
			public uint PresentationIntervals;
			public uint CursorCaps;
			public uint DevCaps;
			public uint PrimitiveMiscCaps;
			public uint RasterCaps;
			public uint ZCmpCaps;
			public uint SrcBlendCaps;
			public uint DestBlendCaps;
			public uint AlphaCmpCaps;
			public uint ShadeCaps;
			public uint TextureCaps;
			public uint TextureFilterCaps;
			public uint CubeTextureFilterCaps;
			public uint VolumeTextureFilterCaps;
			public uint TextureAddressCaps;
			public uint VolumeTextureAddressCaps;
			public uint LineCaps;
			public uint MaxTextureWidth;
			public uint MaxTextureHeight;
			public uint MaxVolumeExtent;
			public uint MaxTextureRepeat;
			public uint MaxTextureAspectRatio;
			public uint MaxAnisotropy;
			public float MaxVertexW;
			public float GuardBandLeft;
			public float GuardBandTop;
			public float GuardBandRight;
			public float GuardBandBottom;
			public float ExtentsAdjust;
			public uint StencilCaps;
			public uint FVFCaps;
			public uint TextureOpCaps;
			public uint MaxTextureBlendStages;
			public uint MaxSimultaneousTextures;
			public uint VertexProcessingCaps;
			public uint MaxActiveLights;
			public uint MaxUserClipPlanes;
			public uint MaxVertexBlendMatrices;
			public uint MaxVertexBlendMatrixIndex;
			public float MaxPointSize;
			public uint MaxPrimitiveCount;
			public uint MaxVertexIndex;
			public uint MaxStreams;
			public uint MaxStreamStride;
			public uint VertexShaderVersion;
			public uint MaxVertexShaderConst;
			public uint PixelShaderVersion;
			public float PixelShader1xMaxValue;
			public uint DevCaps2;
			public float MaxNpatchTessellationLevel;
			public uint Reserved5;
			public uint MasterAdapterOrdinal;  
			public uint AdapterOrdinalInGroup; 
			public uint NumberOfAdaptersInGroup;
			public uint DeclTypes;             
			public uint NumSimultaneousRTs;    
			public uint StretchRectFilterCaps; 
			public D3DVSHADERCAPS2_0 VS20Caps;
			public D3DPSHADERCAPS2_0 PS20Caps;
			public uint VertexTextureFilterCaps;
			public uint MaxVShaderInstructionsExecuted;
			public uint MaxPShaderInstructionsExecuted;
			public uint MaxVertexShader30InstructionSlots;
			public uint MaxPixelShader30InstructionSlots;
		}

		private D3DCAPS9 _caps;

		internal Caps(D3DCAPS9 caps)
		{
			_caps = caps;
		}

		public PixelShaderCaps PixelShaderCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public VertexShaderCaps VertexShaderCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public int MaxPixelShader30InstructionSlots {
			get {
				return (int)_caps.MaxPixelShader30InstructionSlots;
			}
		}

		public int MaxVertexShader30InstructionSlots {
			get {
				return (int)_caps.MaxVertexShader30InstructionSlots;
			}
		}

		public Version PixelShaderVersion {
			get {
				return new Version((int)(_caps.PixelShaderVersion >> 8) & 0xff, (int)_caps.PixelShaderVersion & 0xff);
			}
		}

		public Version VertexShaderVersion {
			get {
				return new Version((int)(_caps.VertexShaderVersion >> 8) & 0xff, (int)_caps.VertexShaderVersion & 0xff);
			}
		}

		public DeclarationTypeCaps DeclTypes {
			get {
				throw new NotImplementedException ();
			}
		}

		public VertexProcessingCaps VertexProcessingCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public VertexFormatCaps VertexFormatCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public TextureOperationCaps TextureOperationCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public StencilCaps StencilCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public AddressCaps VolumeTextureAddressCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public AddressCaps TextureAddressCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public FilterCaps VolumeTextureFilterCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public FilterCaps CubeTextureFilterCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public FilterCaps TextureFilterCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public FilterCaps VertexTextureFilterCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public FilterCaps StretchRectangleFilterCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public TextureCaps TextureCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public int NumberOfAdaptersInGroup {
			get {
				return (int)_caps.NumberOfAdaptersInGroup;
			}
		}

		public int AdapterOrdinalInGroup {
			get {
				return (int)_caps.AdapterOrdinalInGroup;
			}
		}

		public int MasterAdapterOrdinal {
			get {
				return (int)_caps.MasterAdapterOrdinal;
			}
		}

		public int MaxVertexShaderConst {
			get {
				return (int)_caps.MaxVertexShaderConst;
			}
		}

		public int MaxSimultaneousTextures {
			get {
				return (int)_caps.MaxSimultaneousTextures;
				;
			}
		}

		public int MaxTextureBlendStages {
			get {
				return (int)_caps.MaxTextureBlendStages;
			}
		}

		public ShadeCaps ShadeCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public LineCaps LineCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public int NumberSimultaneousRts {
			get {
				return (int)_caps.NumSimultaneousRTs;
			}
		}

		public float PixelShader1xMaxValue {
			get {
				return _caps.PixelShader1xMaxValue;
			}
		}

		public int MaxStreamStride {
			get {
				return (int)_caps.MaxStreamStride;
			}
		}

		public int MaxStreams {
			get {
				return (int)_caps.MaxStreams;
			}
		}

		public int MaxVertexIndex {
			get {
				return (int)_caps.MaxVertexIndex;
			}
		}

		public int MaxPrimitiveCount {
			get {
				return (int)_caps.MaxPrimitiveCount;
			}
		}

		public float MaxPointSize {
			get {
				return _caps.MaxPointSize;
			}
		}

		public int MaxVertexBlendMatrixIndex {
			get {
				return (int)_caps.MaxVertexBlendMatrixIndex;
			}
		}

		public int MaxVertexBlendMatrices {
			get {
				return (int)_caps.MaxVertexBlendMatrices;
			}
		}

		public int MaxUserClipPlanes {
			get {
				return (int)_caps.MaxUserClipPlanes;
			}
		}

		public int MaxActiveLights {
			get {
				return (int)_caps.MaxActiveLights;
			}
		}

		public float ExtentsAdjust {
			get {
				return _caps.ExtentsAdjust;
			}
		}

		public float GuardBandBottom {
			get {
				return _caps.GuardBandBottom;
			}
		}

		public float GuardBandRight {
			get {
				return _caps.GuardBandRight;
			}
		}

		public float GuardBandTop {
			get {
				return _caps.GuardBandTop;
			}
		}

		public float GuardBandLeft {
			get {
				return _caps.GuardBandLeft;
			}
		}

		public float MaxVertexW {
			get {
				return _caps.MaxVertexW;
			}
		}

		public int MaxAnisotropy {
			get {
				return (int)_caps.MaxAnisotropy;
			}
		}

		public int MaxTextureAspectRatio {
			get {
				return (int)_caps.MaxTextureAspectRatio;
			}
		}

		public int MaxTextureRepeat {
			get {
				return (int)_caps.MaxTextureRepeat;
			}
		}

		public int MaxVolumeExtent {
			get {
				return (int)_caps.MaxVolumeExtent;
			}
		}

		public int MaxTextureHeight {
			get {
				return (int)_caps.MaxTextureHeight;
			}
		}

		public int MaxTextureWidth {
			get {
				return (int)_caps.MaxTextureWidth;
			}
		}

		public BlendCaps DestinationBlendCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public BlendCaps SourceBlendCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public ComparisonCaps AlphaCompareCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public ComparisonCaps ZCompareCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public RasterCaps RasterCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public MiscCaps PrimitiveMiscCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public DeviceCaps DeviceCaps {
			get {
				return new DeviceCaps(_caps.DevCaps, _caps.DevCaps2);
			}
		}

		public CursorCaps CursorCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public PresentInterval PresentationIntervals {
			get {
				return (PresentInterval)_caps.PresentationIntervals;
			}
		}

		public DriverCaps DriverCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public int AdapterOrdinal {
			get {
				return (int)_caps.AdapterOrdinal;
			}
		}

		public DeviceType DeviceType {
			get {
				throw new NotImplementedException ();
			}
		}

		public float MaxNPatchTessellationLevel {
			get {
				return _caps.MaxNpatchTessellationLevel;
			}
		}

		public override string ToString ()
		{
			throw new NotImplementedException ();
		}

	}
}
