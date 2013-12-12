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
using NUnit.Framework;
using Microsoft.DirectX;

namespace Test.Microsoft.DirectX
{
	[TestFixture()]
	public class TestMatrix
	{
		[Test()]
		public void TestIdentity ()
		{
			Matrix mat = Matrix.Identity;
			Assert.AreEqual(1.0f, mat.M11);
			Assert.AreEqual(0.0f, mat.M12);
			Assert.AreEqual(0.0f, mat.M13);
			Assert.AreEqual(0.0f, mat.M14);
			Assert.AreEqual(0.0f, mat.M21);
			Assert.AreEqual(1.0f, mat.M22);
			Assert.AreEqual(0.0f, mat.M23);
			Assert.AreEqual(0.0f, mat.M24);
			Assert.AreEqual(0.0f, mat.M31);
			Assert.AreEqual(0.0f, mat.M32);
			Assert.AreEqual(1.0f, mat.M33);
			Assert.AreEqual(0.0f, mat.M34);
			Assert.AreEqual(0.0f, mat.M41);
			Assert.AreEqual(0.0f, mat.M42);
			Assert.AreEqual(0.0f, mat.M43);
			Assert.AreEqual(1.0f, mat.M44);
		}
	}
}

