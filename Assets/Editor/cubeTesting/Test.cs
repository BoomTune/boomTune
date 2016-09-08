using NUnit.Framework;
using System;
using NSubstitute;
using UnityEngine;
//using System.Collections;


namespace cubeTesting
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestCase ()
		{
							
//			 var cubeTesting = Substitute.For<Cube>();
			var cubeTesting = new Cube();


//			Assert.That (cubeTesting.startPos == transform.position, Is.True); 
			Assert.That (cubeTesting, Is.TypeOf(typeof(Cube)));
		}
	}
}

