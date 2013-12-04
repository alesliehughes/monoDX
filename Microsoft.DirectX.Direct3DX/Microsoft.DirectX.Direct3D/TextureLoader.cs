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
using System.IO;

namespace Microsoft.DirectX.Direct3D
{
	public sealed class TextureLoader
	{
		static TextureLoader ()
		{
		}

		public static void CheckTextureRequirements (Device device, Usage usage, Pool pool, out TextureRequirements requirements)
		{
			throw new NotImplementedException ();
		}

		public static void CheckCubeTextureRequirements (Device device, Usage usage, Pool pool, out CubeTextureRequirements requirements)
		{
			throw new NotImplementedException ();
		}

		public static void CheckVolumeTextureRequirements (Device device, Pool pool, out VolumeTextureRequirements requirements)
		{
			throw new NotImplementedException ();
		}

		public static Texture FromFile (Device device, string srcFile, int width, int height, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey)
		{
			throw new NotImplementedException ();
		}

		public static Texture FromFile (Device device, string srcFile, int width, int height, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, out PaletteEntry[] palette)
		{
			throw new NotImplementedException ();
		}

		public static Texture FromFile (Device device, string srcFile, int width, int height, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, ref ImageInformation srcInformation)
		{
			throw new NotImplementedException ();
		}

		public static Texture FromFile (Device device, string srcFile, int width, int height, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, ref ImageInformation srcInformation, out PaletteEntry[] palette)
		{
			throw new NotImplementedException ();
		}

		public static Texture FromFile (Device device, string srcFile)
		{
			throw new NotImplementedException ();
		}

		public static CubeTexture FromCubeFile (Device device, string srcFile, int size, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey)
		{
			throw new NotImplementedException ();
		}

		public static CubeTexture FromCubeFile (Device device, string srcFile, int size, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, out PaletteEntry[] palette)
		{
			throw new NotImplementedException ();
		}

		public static CubeTexture FromCubeFile (Device device, string srcFile, int size, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, ref ImageInformation srcInformation)
		{
			throw new NotImplementedException ();
		}

		public static CubeTexture FromCubeFile (Device device, string srcFile, int size, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, ref ImageInformation srcInformation, out PaletteEntry[] palette)
		{
			throw new NotImplementedException ();
		}

		public static CubeTexture FromCubeFile (Device device, string srcFile)
		{
			throw new NotImplementedException ();
		}

		public static VolumeTexture FromVolumeFile (Device device, string srcFile, int width, int height, int depth, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey)
		{
			throw new NotImplementedException ();
		}

		public static VolumeTexture FromVolumeFile (Device device, string srcFile, int width, int height, int depth, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, out PaletteEntry[] palette)
		{
			throw new NotImplementedException ();
		}

		public static VolumeTexture FromVolumeFile (Device device, string srcFile, int width, int height, int depth, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, ref ImageInformation srcInformation)
		{
			throw new NotImplementedException ();
		}

		public static VolumeTexture FromVolumeFile (Device device, string srcFile, int width, int height, int depth, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, ref ImageInformation srcInformation, out PaletteEntry[] palette)
		{
			throw new NotImplementedException ();
		}

		public static VolumeTexture FromVolumeFile (Device device, string srcFile)
		{
			throw new NotImplementedException ();
		}

		public static Texture FromStream (Device device, Stream stream, int width, int height, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey)
		{
			throw new NotImplementedException ();
		}

		public static Texture FromStream (Device device, Stream stream, int width, int height, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, out PaletteEntry[] palette)
		{
			throw new NotImplementedException ();
		}

		public static Texture FromStream (Device device, Stream stream, int width, int height, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, ref ImageInformation srcInformation)
		{
			throw new NotImplementedException ();
		}

		public static Texture FromStream (Device device, Stream stream, int readBytes, int width, int height, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey)
		{
			throw new NotImplementedException ();
		}

		public static Texture FromStream (Device device, Stream stream, int readBytes, int width, int height, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, out PaletteEntry[] palette)
		{
			throw new NotImplementedException ();
		}

		public static Texture FromStream (Device device, Stream stream, int readBytes, int width, int height, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, ref ImageInformation srcInformation)
		{
			throw new NotImplementedException ();
		}

		public static Texture FromStream (Device device, Stream stream, int readBytes, int width, int height, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, ref ImageInformation srcInformation, out PaletteEntry[] palette)
		{
			throw new NotImplementedException ();
		}

		public static Texture FromStream (Device device, Stream stream)
		{
			throw new NotImplementedException ();
		}

		public static Texture FromStream (Device device, Stream stream, int readBytes)
		{
			throw new NotImplementedException ();
		}

		public static CubeTexture FromCubeStream (Device device, Stream stream, int size, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey)
		{
			throw new NotImplementedException ();
		}

		public static CubeTexture FromCubeStream (Device device, Stream stream, int size, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, out PaletteEntry[] palette)
		{
			throw new NotImplementedException ();
		}

		public static CubeTexture FromCubeStream (Device device, Stream stream, int size, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, ref ImageInformation srcInformation)
		{
			throw new NotImplementedException ();
		}

		public static CubeTexture FromCubeStream (Device device, Stream stream, int readBytes, int size, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey)
		{
			throw new NotImplementedException ();
		}

		public static CubeTexture FromCubeStream (Device device, Stream stream, int readBytes, int size, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, out PaletteEntry[] palette)
		{
			throw new NotImplementedException ();
		}

		public static CubeTexture FromCubeStream (Device device, Stream stream, int readBytes, int size, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, ref ImageInformation srcInformation)
		{
			throw new NotImplementedException ();
		}

		public static CubeTexture FromCubeStream (Device device, Stream stream, int readBytes, int size, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, ref ImageInformation srcInformation, out PaletteEntry[] palette)
		{
			throw new NotImplementedException ();
		}

		public static CubeTexture FromCubeStream (Device device, Stream stream)
		{
			throw new NotImplementedException ();
		}

		public static CubeTexture FromCubeStream (Device device, Stream stream, int readBytes)
		{
			throw new NotImplementedException ();
		}

		public static VolumeTexture FromVolumeStream (Device device, Stream stream, int width, int height, int depth, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey)
		{
			throw new NotImplementedException ();
		}

		public static VolumeTexture FromVolumeStream (Device device, Stream stream, int width, int height, int depth, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, out PaletteEntry[] palette)
		{
			throw new NotImplementedException ();
		}

		public static VolumeTexture FromVolumeStream (Device device, Stream stream, int width, int height, int depth, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, ref ImageInformation srcInformation)
		{
			throw new NotImplementedException ();
		}

		public static VolumeTexture FromVolumeStream (Device device, Stream stream, int readBytes, int width, int height, int depth, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey)
		{
			throw new NotImplementedException ();
		}

		public static VolumeTexture FromVolumeStream (Device device, Stream stream, int readBytes, int width, int height, int depth, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, out PaletteEntry[] palette)
		{
			throw new NotImplementedException ();
		}

		public static VolumeTexture FromVolumeStream (Device device, Stream stream, int readBytes, int width, int height, int depth, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, ref ImageInformation srcInformation)
		{
			throw new NotImplementedException ();
		}

		public static VolumeTexture FromVolumeStream (Device device, Stream stream, int readBytes, int width, int height, int depth, int mipLevels, Usage usage, Format format, Pool pool, Filter filter, Filter mipFilter, int colorKey, ref ImageInformation srcInformation, out PaletteEntry[] palette)
		{
			throw new NotImplementedException ();
		}

		public static VolumeTexture FromVolumeStream (Device device, Stream stream)
		{
			throw new NotImplementedException ();
		}

		public static VolumeTexture FromVolumeStream (Device device, Stream stream, int readBytes)
		{
			throw new NotImplementedException ();
		}

		public static ImageInformation ImageInformationFromFile (string srcFile)
		{
			throw new NotImplementedException ();
		}

		public static ImageInformation ImageInformationFromStream (Stream sourceStream)
		{
			throw new NotImplementedException ();
		}

		public static ImageInformation ImageInformationFromStream (Stream sourceStream, int readLength)
		{
			throw new NotImplementedException ();
		}

		public static void Save (string destFile, ImageFileFormat destFormat, BaseTexture srcTexture)
		{
			throw new NotImplementedException ();
		}

		public static void Save (string destFile, ImageFileFormat destFormat, BaseTexture srcTexture, out PaletteEntry[] sourcePalette)
		{
			throw new NotImplementedException ();
		}

		public static GraphicsStream SaveToStream (ImageFileFormat destFormat, BaseTexture srcTexture)
		{
			throw new NotImplementedException ();
		}

		public static GraphicsStream SaveToStream (ImageFileFormat destFormat, BaseTexture srcTexture, out PaletteEntry[] sourcePalette)
		{
			throw new NotImplementedException ();
		}

		public static void FilterTexture (BaseTexture baseTexture, int srcLevel, Filter filter)
		{
			throw new NotImplementedException ();
		}

		public static void FilterTexture (BaseTexture baseTexture, out PaletteEntry[] palette, int srcLevel, Filter filter)
		{
			throw new NotImplementedException ();
		}

		public static void FillTexture (VolumeTexture texture, TextureShader textureShader)
		{
			throw new NotImplementedException ();
		}

		public static void FillTexture (CubeTexture texture, TextureShader textureShader)
		{
			throw new NotImplementedException ();
		}

		public static void FillTexture (Texture texture, TextureShader textureShader)
		{
			throw new NotImplementedException ();
		}

		public static void FillTexture (VolumeTexture texture, Fill3DTextureCallback callbackFunction)
		{
			throw new NotImplementedException ();
		}

		public static void FillTexture (CubeTexture texture, Fill3DTextureCallback callbackFunction)
		{
			throw new NotImplementedException ();
		}

		public static void FillTexture (Texture texture, Fill2DTextureCallback callbackFunction)
		{
			throw new NotImplementedException ();
		}
		
		public static void ComputeNormalMap (Texture texture, Texture srcTexture, NormalMap flags, Channel channel, float amplitude)
		{
			throw new NotImplementedException ();
		}

		public static void ComputeNormalMap (Texture texture, Texture srcTexture, out PaletteEntry[] sourcePalette, NormalMap flags, Channel channel, float amplitude)
		{
			throw new NotImplementedException ();
		}
	}
}
