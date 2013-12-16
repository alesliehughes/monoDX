using System;
using NUnit.Framework;
using Microsoft.DirectX.Direct3D;

namespace Test.Microsoft.DirectX.Direct3DX
{
	[TestFixture()]
	public class TestSprite
	{
		[Test()]
		public void TestCreate ()
		{
			Sprite sprite = new Sprite( (IntPtr)null);
			Assert.IsNotNull(sprite);
		}
	}
}

