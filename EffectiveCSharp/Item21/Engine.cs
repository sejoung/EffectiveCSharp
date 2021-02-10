using System;

namespace EffectiveCSharp.Item21
{
	public interface IEngine
	{
		void DoWork();
	}

	public class EnginDriverOne<T> where T : IEngine, new()
	{
		public void GetThingDone()
		{
			T driver = new T();

			using (driver as IDisposable)
			{
				driver.DoWork();	
			}
			
		}
	}
}