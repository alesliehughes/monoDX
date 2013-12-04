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
using System.Reflection;

namespace Microsoft.DirectX.Direct3D
{
	[DefaultMember("Value")]
	public struct BehaviorFlags
	{
		public bool AdapterGroupDevice {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool DisableDriverManagement {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public bool MixedVertexProcessing {
		
			get {
				throw new NotImplementedException ();
			}
		}

		public bool MultiThreaded {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public bool HardwareVertexProcessing {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public bool SoftwareVertexProcessing {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public bool PureDevice {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public bool FpuPreserve {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public CreateFlags Value {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public override string ToString ()
		{
			throw new NotImplementedException ();
		}

		public BehaviorFlags (params CreateFlags[] newBehavior)
		{
			
		}

		public BehaviorFlags (CreateFlags initialBehavior)
		{
			
		}
	}
}
