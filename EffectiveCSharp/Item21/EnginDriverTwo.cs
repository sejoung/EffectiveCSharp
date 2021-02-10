using System;

namespace EffectiveCSharp.Item21
{
	public class EnginDriverTwo<T> : IDisposable where T : IEngine, new()
	{
		private Lazy<T> driver = new(()=> new T());
		
		public void GetThingDone() => driver.Value.DoWork();
		
		public void Dispose()
		{
			if (driver.IsValueCreated)
			{
				var resource = driver.Value as IDisposable;
				resource?.Dispose();
			}
		}
	}
}