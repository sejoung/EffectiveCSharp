namespace EffectiveCSharp.Item17
{
	public class DrivedResourceHog : MyResourceHog
	{
		private bool disposed = false;

		protected override void Dispose(bool isDisposing)
		{
			if (disposed)
			{
				return;
			}

			if (isDisposing)
			{
				// 관리 리소스 정리
			}
			// 비관리 리소스 정리
			
			//베이스 클래스가 자신의 리소스를 정리하도록 호출
			base.Dispose(isDisposing);
			disposed = true;
		}
	}
}