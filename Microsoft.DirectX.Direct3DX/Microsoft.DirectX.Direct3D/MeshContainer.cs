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
	public abstract class MeshContainer
	{
		public string Name
		{
			get
			{
			throw new NotImplementedException ();
			}
			set
			{
				throw new NotImplementedException ();
			}
		}
		public MeshContainer NextContainer
		{
			get
			{
			throw new NotImplementedException ();
			}
		}
		public MeshData MeshData
		{
			get
			{
				throw new NotImplementedException ();
			}
			set
			{
				throw new NotImplementedException ();
			}
		}
		public SkinInformation SkinInformation {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		static MeshContainer()
		{
			
		}
		public MeshContainer()
		{
			
		}

		public ExtendedMaterial[] GetMaterials()
		{
			throw new NotImplementedException ();
		}
		public void SetAdjacency(GraphicsStream adj)
		{
			throw new NotImplementedException ();
		}
		public void SetAdjacency(int[] adj)
		{
			throw new NotImplementedException ();
		}
		public int[] GetAdjacency()
		{
			throw new NotImplementedException ();
		}
		public GraphicsStream GetAdjacencyStream()
		{
			throw new NotImplementedException ();
		}
		public EffectInstance[] GetEffectInstances()
		{
			throw new NotImplementedException ();
		}
		public void SetMaterials(ExtendedMaterial[] mtrl)
		{
			throw new NotImplementedException ();
		}
		public void SetEffectInstances(EffectInstance[] effects)
		{
			throw new NotImplementedException ();
		}
	
	
	}
}


