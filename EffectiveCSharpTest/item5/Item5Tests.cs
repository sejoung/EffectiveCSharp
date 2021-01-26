using System;
using NUnit.Framework;

namespace EffectiveCSharpTest.item5
{
	public class Item5Tests
	{
		[Test]
		public void Test1()
		{
			// 새로운 문자열
			string first = $"It`s the {DateTime.Now.Day} of the {DateTime.Now.Month} month";

			// FormattableString
			FormattableString second = $"It`s the {DateTime.Now.Day} of the {DateTime.Now.Month} month";

			// string or FormattableString
			var third =  $"It`s the {DateTime.Now.Day} of the {DateTime.Now.Month} month";
			
			Console.WriteLine(first);
			Console.WriteLine(second);
			Console.WriteLine(third);
		}
	}
}