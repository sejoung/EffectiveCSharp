using System;
using EffectiveCSharp.Item14;
using NUnit.Framework;

namespace EffectiveCSharpTest.Item14
{
	public class Tests
	{
		[Test]
		public void Test1()
		{

			var a = new MyClass(1,"123");

			var importantData = new ImportantData("abc",DateTime.Now);
			
			a.addImportantData(importantData);
			
			TestContext.WriteLine(a);
		}

	
	}
}