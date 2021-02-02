using System;

namespace EffectiveCSharp.Item17
{
	public class MyResourceHog : IDisposable
	{
		private bool alreadyDisposed = false;

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool isDisposing)
		{
			if (alreadyDisposed)
			{
				return;
			}

			if (isDisposing)
			{
				// 관리 리소스 정리
			}
			
			// 비관리 리소스 정리

			alreadyDisposed = true;
		}

		public void ExampleMethod()
		{
			if (alreadyDisposed)
			{
				throw new ObjectDisposedException("MyResourceHog", "Called Example Method on Disposed object");
			}
		}
	}
}