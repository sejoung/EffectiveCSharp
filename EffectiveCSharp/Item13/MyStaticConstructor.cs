namespace EffectiveCSharp.Item13
{
	public class MyStaticConstructor
	{
		private static readonly MyStaticConstructor theOneAndOnly;

		static MyStaticConstructor()
		{
			theOneAndOnly = new MyStaticConstructor();
		}

		public static MyStaticConstructor TheOneAndOnly => theOneAndOnly;

		private MyStaticConstructor()
		{
			
		}
	}
}