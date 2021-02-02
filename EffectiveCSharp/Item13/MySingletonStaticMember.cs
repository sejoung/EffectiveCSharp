namespace EffectiveCSharp.Item13
{
	public class MySingletonStaticMember
	{
		private static readonly MySingletonStaticMember theOneAndOnly = new MySingletonStaticMember();

		public static MySingletonStaticMember TheOneAndOnly => theOneAndOnly;

		private MySingletonStaticMember()
		{
		}
		
		
		
	}
}