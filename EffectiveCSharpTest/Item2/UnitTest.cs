using System;
using EffectiveCSharp.Item2;
using NUnit.Framework;

namespace EffectiveCSharpTest
{
	public class Tests
	{
		[Test]
		public void Test1()
		{
			Animal animal = new Dog("멍멍이");

			if (animal is Dog)
			{
				if (animal != null)
				{
					animal.Saying();
				}
			}


			Assert.Pass();
		}


		[Test]
		public void Test2()
		{
			Animal animal = new Cat("야옹");
			Dog dog = animal as Dog;

			if (dog != null)
			{
				dog.Saying();
			}

			Assert.Pass();
		}

		[Test]
		public void Test3()
		{
			Animal animal = new Dog("멍멍이");
			Dog dog = (Dog) animal;

			if (dog != null)
			{
				dog.Saying();
			}

			Assert.Pass();
		}

		[Test]
		public void Test4()
		{
			Animal animal = new Cat("야옹");

			Assert.Throws(typeof(InvalidCastException), delegate
			{
				Dog dog = (Dog) animal;
			});
		}

		[Test]
		public void Test5()
		{
			double num = 12.12;
			Assert.AreEqual(12,(int) num);
		}
		
	}
}