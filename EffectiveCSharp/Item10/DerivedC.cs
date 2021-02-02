using System;

namespace EffectiveCSharp.Item10
{
	public class DerivedC : BaseC
	{
		new public void Invoke() {
			Console.WriteLine("derivedC");
		}
	}
}