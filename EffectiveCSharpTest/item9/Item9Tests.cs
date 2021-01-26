using System;
using System.Collections.Generic;
using EffectiveCSharp.item9;
using NUnit.Framework;

namespace EffectiveCSharpTest.item9
{
	public class Item9Tests
	{
		[Test]
		public void Test1()
		{

			int i = 25;
			object o = i;//박싱

			Console.WriteLine(o.ToString());
		}
		
		[Test]
		public void Test2()
		{
			object firstParm = 5;
			object o = firstParm;
			int i = (int) o; //언박싱
			Console.WriteLine(o.ToString());
		}
		
		[Test]
		public void Test3()
		{

			var attendees = new List<Person>();

			Person p = new Person {Name = "Old Name"};
			attendees.Add(p);

			Person p2 = attendees[0];
			p2.Name = "New Name";

			Console.WriteLine(attendees[0].ToString());
			
			
		}

	}
	
}