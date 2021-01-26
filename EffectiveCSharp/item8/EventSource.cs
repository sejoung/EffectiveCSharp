using System;

namespace EffectiveCSharp.item8
{
	public class EventSource
	{
		private EventHandler<int> Updated;

		public void RaiseUpdates()
		{
			counter++;
			Updated(this, counter);
		}

		private int counter;
	}


	public class EventSource2
	{
		private EventHandler<int> Updated;

		public void RaiseUpdates()
		{
			counter++;
			if (Updated != null)
				Updated(this, counter);
		}

		private int counter;
	}
	
	public class EventSource3
	{
		private EventHandler<int> Updated;

		public void RaiseUpdates()
		{
			counter++;
			var handler = Updated;
			if (handler != null)
				handler(this, counter);
		}

		private int counter;
	}
	
	public class EventSource4
	{
		private EventHandler<int> Updated;

		public void RaiseUpdates()
		{
			counter++;
			Updated?.Invoke(this, counter);
		}

		private int counter;
	}
}