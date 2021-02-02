using EffectiveCSharp.Item10;
using NUnit.Framework;

namespace EffectiveCSharpTest.Item10
{
	public class Tests
	{
		[Test]
		public void Test1()
		{

			var testC = new TestBaseC();
			testC.Invoke();

			var derivedC = new DerivedC();
			derivedC.Invoke();

			var baseCOverride =new BaseOverride();
			
			baseCOverride.Invoke();
		}

	
	}
}