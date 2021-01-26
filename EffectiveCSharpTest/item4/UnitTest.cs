using System;
using NUnit.Framework;

namespace EffectiveCSharpTest
{
	public class Item4Tests
	{
		[Test]
		public void Test1()
		{

			string name = "길동";
			Console.WriteLine(string.Format("{0}",name));
			Console.WriteLine($"{name}");
			Console.WriteLine($"{Math.PI.ToString()}");
			Console.WriteLine($"{Math.PI.ToString("F2")}");
			Console.WriteLine($"{Math.PI:F2}");
			
			//Console.WriteLine($"{true ? Math.PI.ToString() : Math.PI.ToString("F2")}");
			Console.WriteLine($"{(true ? Math.PI.ToString() : Math.PI.ToString("F2"))}");

			Assert.Pass();
		}
		
	}
}