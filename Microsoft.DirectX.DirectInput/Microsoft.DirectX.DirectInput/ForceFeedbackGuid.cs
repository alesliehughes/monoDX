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

namespace Microsoft.DirectX.DirectInput
{
	public sealed class ForceFeedbackGuid
	{
		public static readonly Guid ConstantForce;
		public static readonly Guid RampForce;
		public static readonly Guid Square;
		public static readonly Guid Sine;
		public static readonly Guid Triangle;
		public static readonly Guid SawtoothUp;
		public static readonly Guid SawtoothDown;
		public static readonly Guid Spring;
		public static readonly Guid Damper;
		public static readonly Guid Inertia;
		public static readonly Guid Friction;
		public static readonly Guid CustomForce;

		static ForceFeedbackGuid()
		{
			throw new NotImplementedException ();
		}
	}
}

