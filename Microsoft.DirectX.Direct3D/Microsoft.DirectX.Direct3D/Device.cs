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
using Microsoft.DirectX.PrivateImplementationDetails;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Microsoft.DirectX.Direct3D
{
	public sealed class Device : MarshalByRefObject, IDisposable
	{
		public event EventHandler Disposing {

			add {
				throw new NotImplementedException ();
			}
			remove {
				throw new NotImplementedException ();
			}
		}

		public event CancelEventHandler DeviceResizing {
			
			add {
				throw new NotImplementedException ();
			}

			remove {
				throw new NotImplementedException ();
			}
		}

		public event EventHandler DeviceReset {
			add {
				throw new NotImplementedException ();
			}
			
			remove {
				throw new NotImplementedException ();
			}
		}

		public event EventHandler DeviceLost {
			
			add {
				throw new NotImplementedException ();
			}
			
			remove {
				throw new NotImplementedException ();
			}
		}

		[CLSCompliant(false)]
		public unsafe IDirect3DDevice9* UnmanagedComPointer {
			get {
				throw new NotImplementedException ();
			}
		}

		public PresentParameters PresentationParameters {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool Disposed {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public ClipPlanes ClipPlanes {
			get {
				throw new NotImplementedException ();
			}
		}

		public LightsCollection Lights {
			get {
				throw new NotImplementedException ();
			}
		}

		public SamplerStateManagerCollection SamplerState {
			get {
				throw new NotImplementedException ();
			}
		}

		public TextureStateManagerCollection TextureState {
			get {
				throw new NotImplementedException ();
			}
		}

		public Transforms Transform {
			get {
				throw new NotImplementedException ();
			}
		}

		public RenderStateManager RenderState {
			get {
				throw new NotImplementedException ();
			}
		}

		public float NPatchMode {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public bool SoftwareVertexProcessing {
			
			get {
				throw new NotImplementedException ();
			}
			
			set {
				throw new NotImplementedException ();
			}
		}

		public int NumberOfSwapChains {
			get {
				throw new NotImplementedException ();
			}
		}

		public VertexFormats VertexFormat {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public VertexDeclaration VertexDeclaration {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public Rectangle ScissorRectangle {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public IndexBuffer Indices {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public Surface DepthStencilSurface {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public PixelShader PixelShader {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public VertexShader VertexShader {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public int CurrentTexturePalette {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public ClipStatus ClipStatus {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public Material Material {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public Viewport Viewport {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public RasterStatus RasterStatus {
			get {
				throw new NotImplementedException ();
			}
		}

		public DeviceCreationParameters CreationParameters {
			get {
				throw new NotImplementedException ();
			}
		}

		public DisplayMode DisplayMode {
			get {
				throw new NotImplementedException ();
			}
		}

		public Caps DeviceCaps {
			get {
				throw new NotImplementedException ();
			}
		}

		public int AvailableTextureMemory {
			get {
				throw new NotImplementedException ();
			}
		}

		public static bool IsUsingEventHandlers {
			
			get {
				throw new NotImplementedException ();
			}
			[param: MarshalAs(4)]
			set {
				throw new NotImplementedException ();
			}
		}
		
		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator == (Device left, Device right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (Device left, Device right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode ()
		{
			throw new NotImplementedException ();
		}

		public void Dispose ()
		{
			throw new NotImplementedException ();
		}

		static Device ()
		{
			
		}
		
		public bool CheckCooperativeLevel ()
		{
			throw new NotImplementedException ();
		}
		
		public bool CheckCooperativeLevel (out int result)
		{
			throw new NotImplementedException ();
		}

		public void TestCooperativeLevel ()
		{
			throw new NotImplementedException ();
		}
		
		public void SetCursorPosition (int positionX, int positionY, bool updateImmediate)
		{
			throw new NotImplementedException ();
		}
		
		public bool ShowCursor (bool canShow)
		{
			throw new NotImplementedException ();
		}

		public void Reset (params PresentParameters[] presentationParameters)
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

		public RasterStatus GetRasterStatus (int swapChain)
		{
			throw new NotImplementedException ();
		}

		public GammaRamp GetGammaRamp (int swapChain)
		{
			throw new NotImplementedException ();
		}

		public void SetGammaRamp (int swapChain, bool calibrate, GammaRamp ramp)
		{
			throw new NotImplementedException ();
		}

		public void BeginScene ()
		{
			throw new NotImplementedException ();
		}

		public void EndScene ()
		{
			throw new NotImplementedException ();
		}

		public void Clear (ClearFlags flags, Color color, float zdepth, int stencil)
		{
			throw new NotImplementedException ();
		}

		public void Clear (ClearFlags flags, Color color, float zdepth, int stencil, Rectangle[] rect)
		{
			throw new NotImplementedException ();
		}

		public void Clear (ClearFlags flags, int color, float zdepth, int stencil)
		{
			throw new NotImplementedException ();
		}

		public void Clear (ClearFlags flags, int color, float zdepth, int stencil, Rectangle[] regions)
		{
			throw new NotImplementedException ();
		}

		public void SetTransform (TransformType state, Matrix matrix)
		{
			throw new NotImplementedException ();
		}
		
		public Matrix GetTransform (TransformType state)
		{
			throw new NotImplementedException ();
		}

		public void MultiplyTransform (TransformType state, Matrix matrix)
		{
			throw new NotImplementedException ();
		}
	
		public void SetRenderState (RenderStates state, float value)
		{
			throw new NotImplementedException ();
		}

		public void SetRenderState (RenderStates state, bool value)
		{
			throw new NotImplementedException ();
		}

		public void SetRenderState (RenderStates state, int value)
		{
			throw new NotImplementedException ();
		}

		public int GetRenderStateInt32 (RenderStates state)
		{
			throw new NotImplementedException ();
		}

		public float GetRenderStateSingle (RenderStates state)
		{
			throw new NotImplementedException ();
		}
		
		public bool GetRenderStateBoolean (RenderStates state)
		{
			throw new NotImplementedException ();
		}

		public void BeginStateBlock ()
		{
			throw new NotImplementedException ();
		}

		public StateBlock EndStateBlock ()
		{
			throw new NotImplementedException ();
		}
		
		public void SetSamplerState (int stage, SamplerStageStates state, float value)
		{
			throw new NotImplementedException ();
		}

		public void SetSamplerState (int stage, SamplerStageStates state, bool value)
		{
			throw new NotImplementedException ();
		}

		public void SetSamplerState (int stage, SamplerStageStates state, int value)
		{
			throw new NotImplementedException ();
		}

		public int GetSamplerStageStateInt32 (int stage, SamplerStageStates state)
		{
			throw new NotImplementedException ();
		}
		
		public bool GetSamplerStageStateBoolean (int stage, SamplerStageStates state)
		{
			throw new NotImplementedException ();
		}

		public float GetSamplerStageStateSingle (int stage, SamplerStageStates state)
		{
			throw new NotImplementedException ();
		}

		public void SetTextureStageState (int stage, TextureStageStates state, float value)
		{
			throw new NotImplementedException ();
		}

		public void SetTextureStageState (int stage, TextureStageStates state, bool value)
		{
			throw new NotImplementedException ();
		}

		public void SetTextureStageState (int stage, TextureStageStates state, int value)
		{
			throw new NotImplementedException ();
		}

		public int GetTextureStageStateInt32 (int stage, TextureStageStates state)
		{
			throw new NotImplementedException ();
		}
		
		public bool GetTextureStageStateBoolean (int stage, TextureStageStates state)
		{
			throw new NotImplementedException ();
		}

		public float GetTextureStageStateSingle (int stage, TextureStageStates state)
		{
			throw new NotImplementedException ();
		}

		public ValidateDeviceParams ValidateDevice ()
		{
			throw new NotImplementedException ();
		}

		public void SetPaletteEntries (int paletteNumber, PaletteEntry[] entries)
		{
			throw new NotImplementedException ();
		}

		public PaletteEntry[] GetPaletteEntries (int paletteNumber)
		{
			throw new NotImplementedException ();
		}

		public void DrawPrimitives (PrimitiveType primitiveType, int startVertex, int primitiveCount)
		{
			throw new NotImplementedException ();
		}

		public void DrawIndexedPrimitives (PrimitiveType primitiveType, int baseVertex, int minVertexIndex, int numVertices, int startIndex, int primCount)
		{
			throw new NotImplementedException ();
		}

		public void DrawUserPrimitives (PrimitiveType primitiveType, int primitiveCount, object vertexStreamZeroData)
		{
			throw new NotImplementedException ();
		}

		public void DrawIndexedUserPrimitives (PrimitiveType primitiveType, int minVertexIndex, int numVertexIndices, int primitiveCount, object indexData, bool sixteenBitIndices, object vertexStreamZeroData)
		{
			throw new NotImplementedException ();
		}
		
		[CLSCompliant(false)]
		public unsafe void SetVertexShaderConstant (int startRegister, Vector4* constantData)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void SetVertexShaderConstant (int startRegister, Matrix* constantData)
		{
			throw new NotImplementedException ();
		}

		public void SetVertexShaderConstant (int startRegister, Vector4 constantData)
		{
			throw new NotImplementedException ();
		}

		public void SetVertexShaderConstant (int startRegister, Matrix constantData)
		{
			throw new NotImplementedException ();
		}

		public void SetVertexShaderConstant (int startRegister, bool[] constantData)
		{
			throw new NotImplementedException ();
		}

		public void SetVertexShaderConstant (int startRegister, int[] constantData)
		{
			throw new NotImplementedException ();
		}

		public void SetVertexShaderConstant (int startRegister, Vector4[] constantData)
		{
			throw new NotImplementedException ();
		}

		public void SetVertexShaderConstant (int startRegister, Matrix[] constantData)
		{
			throw new NotImplementedException ();
		}

		public void SetVertexShaderConstant (int startRegister, float[] constantData)
		{
			throw new NotImplementedException ();
		}

		public void SetVertexShaderConstantSingle (int startRegister, GraphicsStream constantData, int numberRegisters)
		{
			throw new NotImplementedException ();
		}

		public void SetVertexShaderConstantInt32 (int startRegister, GraphicsStream constantData, int numberRegisters)
		{
			throw new NotImplementedException ();
		}

		public void SetVertexShaderConstantBoolean (int startRegister, GraphicsStream constantData, int numberRegisters)
		{
			throw new NotImplementedException ();
		}

		public float[] GetVertexShaderSingleConstant (int startRegister, int constantCount)
		{
			throw new NotImplementedException ();
		}

		public int[] GetVertexShaderInt32Constant (int startRegister, int constantCount)
		{
			throw new NotImplementedException ();
		}

		public bool[] GetVertexShaderBooleanConstant (int startRegister, int constantCount)
		{
			throw new NotImplementedException ();
		}
	
		[CLSCompliant(false)]
		public unsafe void SetPixelShaderConstant (int startRegister, Vector4* constantData)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void SetPixelShaderConstant (int startRegister, Matrix* constantData)
		{
			throw new NotImplementedException ();
		}

		public void SetPixelShaderConstant (int startRegister, Vector4 constantData)
		{
			throw new NotImplementedException ();
		}

		public void SetPixelShaderConstant (int startRegister, Matrix constantData)
		{
			throw new NotImplementedException ();
		}

		public void SetPixelShaderConstant (int startRegister, bool[] constantData)
		{
			throw new NotImplementedException ();
		}

		public void SetPixelShaderConstant (int startRegister, int[] constantData)
		{
			throw new NotImplementedException ();
		}

		public void SetPixelShaderConstant (int startRegister, Vector4[] constantData)
		{
			throw new NotImplementedException ();
		}

		public void SetPixelShaderConstant (int startRegister, Matrix[] constantData)
		{
			throw new NotImplementedException ();
		}

		public void SetPixelShaderConstant (int startRegister, float[] constantData)
		{
			throw new NotImplementedException ();
		}

		public void SetPixelShaderConstantSingle (int startRegister, GraphicsStream constantData, int numberRegisters)
		{
			throw new NotImplementedException ();
		}

		public void SetPixelShaderConstantInt32 (int startRegister, GraphicsStream constantData, int numberRegisters)
		{
			throw new NotImplementedException ();
		}

		public void SetPixelShaderConstantBoolean (int startRegister, GraphicsStream constantData, int numberRegisters)
		{
			throw new NotImplementedException ();
		}

		public float[] GetPixelShaderSingleConstant (int startRegister, int constantCount)
		{
			throw new NotImplementedException ();
		}

		public int[] GetPixelShaderInt32Constant (int startRegister, int constantCount)
		{
			throw new NotImplementedException ();
		}

		public bool[] GetPixelShaderBooleanConstant (int startRegister, int constantCount)
		{
			throw new NotImplementedException ();
		}

		public void DrawRectanglePatch (int handle, Plane numSegs, RectanglePatchInformation rectPatchInformation)
		{
			throw new NotImplementedException ();
		}

		public void DrawRectanglePatch (int handle, float[] numSegs, RectanglePatchInformation rectPatchInformation)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void DrawRectanglePatch (int handle, Plane numSegs, RectanglePatchInformation* rectPatchInformation)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void DrawRectanglePatch (int handle, float[] numSegs, RectanglePatchInformation* rectPatchInformation)
		{
			throw new NotImplementedException ();
		}

		public void DrawRectanglePatch (int handle, Plane numSegs)
		{
			throw new NotImplementedException ();
		}

		public void DrawRectanglePatch (int handle, float[] numSegs)
		{
			throw new NotImplementedException ();
		}

		public void DrawTrianglePatch (int handle, Plane numSegs, TrianglePatchInformation triPatchInformation)
		{
			throw new NotImplementedException ();
		}

		public void DrawTrianglePatch (int handle, float[] numSegs, TrianglePatchInformation triPatchInformation)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void DrawTrianglePatch (int handle, Plane numSegs, TrianglePatchInformation* triPatchInformation)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void DrawTrianglePatch (int handle, float[] numSegs, TrianglePatchInformation* triPatchInformation)
		{
			throw new NotImplementedException ();
		}

		public void DrawTrianglePatch (int handle, Plane numSegs)
		{
			throw new NotImplementedException ();
		}

		public void DrawTrianglePatch (int handle, float[] numSegs)
		{
			throw new NotImplementedException ();
		}

		public void DeletePatch (int handle)
		{
			throw new NotImplementedException ();
		}

		public void UpdateTexture (BaseTexture sourceTexture, BaseTexture destinationTexture)
		{
			throw new NotImplementedException ();
		}

		public void SetTexture (int stage, BaseTexture texture)
		{
			throw new NotImplementedException ();
		}

		public Texture GetTexture (int stage)
		{
			throw new NotImplementedException ();
		}

		public CubeTexture GetCubeTexture (int stage)
		{
			throw new NotImplementedException ();
		}

		public VolumeTexture GetVolumeTexture (int stage)
		{
			throw new NotImplementedException ();
		}

		public void SetCursorProperties (int hotSpotX, int hotSpotY, Surface cursorBitmap)
		{
			throw new NotImplementedException ();
		}

		public void SetCursor (Cursor cursor, bool addWaterMark)
		{
			throw new NotImplementedException ();
		}

		public Surface GetBackBuffer (int swapChain, int backBuffer, BackBufferType backBufferType)
		{
			throw new NotImplementedException ();
		}

		public Surface CreateRenderTarget (int width, int height, Format format, MultiSampleType multiSample, int multiSampleQuality, bool lockable)
		{
			throw new NotImplementedException ();
		}

		public Surface CreateDepthStencilSurface (int width, int height, DepthFormat format, MultiSampleType multiSample, int multiSampleQuality, bool discard)
		{
			throw new NotImplementedException ();
		}

		public Surface CreateOffscreenPlainSurface (int width, int height, Format format, Pool pool)
		{
			throw new NotImplementedException ();
		}
		
		public void UpdateSurface (Surface sourceSurface, Surface destinationSurface)
		{
			throw new NotImplementedException ();
		}

		public void UpdateSurface (Surface sourceSurface, Surface destinationSurface, Point destPoint)
		{
			throw new NotImplementedException ();
		}

		public void UpdateSurface (Surface sourceSurface, Rectangle sourceRect, Surface destinationSurface)
		{
			throw new NotImplementedException ();
		}

		public void UpdateSurface (Surface sourceSurface, Rectangle sourceRect, Surface destinationSurface, Point destPoint)
		{
			throw new NotImplementedException ();
		}

		public void GetFrontBufferData (int swapChain, Surface buffer)
		{
			throw new NotImplementedException ();
		}

		public void GetRenderTargetData (Surface renderTarget, Surface destSurface)
		{
			throw new NotImplementedException ();
		}

		public void SetRenderTarget (int renderTargetIndex, Surface renderTarget)
		{
			throw new NotImplementedException ();
		}

		public Surface GetRenderTarget (int renderTargetIndex)
		{
			throw new NotImplementedException ();
		}

		public void ProcessVertices (int srcStartIndex, int destIndex, int vertexCount, VertexBuffer destBuffer, VertexDeclaration vertexDeclaration)
		{
			throw new NotImplementedException ();
		}

		public void ProcessVertices (int srcStartIndex, int destIndex, int vertexCount, VertexBuffer destBuffer, VertexDeclaration vertexDeclaration, bool copyData)
		{
			throw new NotImplementedException ();
		}

		public void SetStreamSource (int streamNumber, VertexBuffer streamData, int offsetInBytes)
		{
			throw new NotImplementedException ();
		}

		public void SetStreamSource (int streamNumber, VertexBuffer streamData, int offsetInBytes, int stride)
		{
			throw new NotImplementedException ();
		}

		public VertexBuffer GetStreamSource (int streamNumber, out int offsetInBytes, out int stride)
		{
			throw new NotImplementedException ();
		}

		public void SetStreamSourceFrequency (int streamNumber, int divider)
		{
			throw new NotImplementedException ();
		}

		public int GetStreamSourceFrequency (int streamNumber)
		{
			throw new NotImplementedException ();
		}

		public void StretchRectangle (Surface sourceSurface, Rectangle sourceRectangle, Surface destSurface, Rectangle destRectangle, TextureFilter filter)
		{
			throw new NotImplementedException ();
		}

		public void ColorFill (Surface surface, Rectangle rect, Color color)
		{
			throw new NotImplementedException ();
		}

		public void ColorFill (Surface surface, Rectangle rect, int color)
		{
			throw new NotImplementedException ();
		}

		public void SetDialogBoxesEnabled (bool value)
		{
			throw new NotImplementedException ();
		}

		public SwapChain GetSwapChain (int swapChain)
		{
			throw new NotImplementedException ();
		}

		public void EvictManagedResources ()
		{
			throw new NotImplementedException ();
		}
	
		[CLSCompliant(false)]
		public unsafe Device (IDirect3DDevice9* pUnk)
		{
			throw new NotImplementedException ();
		}

		public unsafe Device (IntPtr unmanagedObject)
		{
			throw new NotImplementedException ();
		}

		public Device (int adapter, DeviceType deviceType, IntPtr renderWindowHandle, CreateFlags behaviorFlags, params PresentParameters[] presentationParameters)
		{
			throw new NotImplementedException ();
		}

		public Device (int adapter, DeviceType deviceType, Control renderWindow, CreateFlags behaviorFlags, params PresentParameters[] presentationParameters)
		{
			throw new NotImplementedException ();
		}

		[EditorBrowsable]
		public IntPtr GetObjectByValue (int uniqueKey)
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void UpdateUnmanagedPointer (IDirect3DDevice9* pInterface)
		{
			throw new NotImplementedException ();
		}

	}
}


