using System;

namespace EffectiveCSharp.Item16
{
	public class B
	{
		public B()
		{
			VFunc();
		}

		protected virtual void VFunc()
		{
			Console.WriteLine("VFunc in B");
		}
	}

	public class Derived : B
	{
		private readonly string msg = "Set by initializer";

		public Derived(string msg)
		{
			this.msg = msg;
		}

		protected override void VFunc()
		{
			Console.WriteLine(msg);
		}
	}
}