namespace EffectiveCSharp.Item21
{
	public sealed class EnginDriver<T> where T : IEngine
	{
		private T driver;

		public EnginDriver(T driver)
		{
			this.driver = driver;
		}

		public void GetThingDone()
		{
			driver.DoWork();
		}
	}
}