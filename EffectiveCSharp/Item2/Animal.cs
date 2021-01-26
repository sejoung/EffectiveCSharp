using System;

namespace EffectiveCSharp.Item2
{
	public abstract class Animal
	{
		private readonly string name;

		protected Animal(string name)
		{
			this.name = name;
		}

		private Animal()
		{
		}

		public void Saying()
		{
			Console.WriteLine(name);
		}
	}
}