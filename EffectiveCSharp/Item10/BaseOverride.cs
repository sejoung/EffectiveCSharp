using System;

namespace EffectiveCSharp.Item10
{
	public class BaseOverride : BaseV
	{
		public override void Invoke()
		{
			Console.WriteLine("BaseCOverride");
		}
	}
}