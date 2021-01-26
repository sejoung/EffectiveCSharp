using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace EffectiveCSharpTest.item6
{
	public class Item6Tests
	{
		private string name;

		public string Name
		{
			get => name;
			set => name = value ?? throw new ArgumentNullException(nameof(value), $"{nameof(Name)} cannot be null");
		}
		
		
		[Test]
		public void Test1()
		{
			Console.WriteLine(nameof(System.Collections.Generic));  // output: Generic
			Console.WriteLine(nameof(List<int>));  // output: List
			Console.WriteLine(nameof(List<int>.Count));  // output: Count
			Console.WriteLine(nameof(List<int>.Add));  // output: Add

			var numbers = new List<int> { 1, 2, 3 };
			Console.WriteLine(nameof(numbers));  // output: numbers
			Console.WriteLine(nameof(numbers.Count));  // output: Count
			Console.WriteLine(nameof(numbers.Add));  // output: Add
			
		}
	}
}