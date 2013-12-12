using System;
using NUnit.Framework;
using Microsoft.DirectX;

namespace Test.Microsoft.DirectX
{
	[TestFixture()]
	public class TestQuaternion
	{
		[Test()]
		public void TestIdentity ()
		{
			Quaternion q = Quaternion.Identity;
			Assert.AreEqual(1.0f, q.W);
			Assert.AreEqual(0.0f, q.X);
			Assert.AreEqual(0.0f, q.Y);
			Assert.AreEqual(0.0f, q.Z);
		}
	}
}

