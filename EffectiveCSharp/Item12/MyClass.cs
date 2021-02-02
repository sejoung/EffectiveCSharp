using System.Collections.Generic;

namespace EffectiveCSharp.Item12
{
	public class MyClass
	{
		private List<string> labels;

		public MyClass(List<string> labels)
		{
			this.labels = labels;
		}
	}
	
	public class MyClass2
	{
		private List<string> labels = new List<string>();

		public MyClass2()
		{
		}

		public MyClass2(int size)
		{
			labels = new List<string>(size);
		}
	}
	
	public class MyClass3
	{
		private List<string> labels;

		public MyClass3()
		{
			labels = new List<string>();
		}

		public MyClass3(int size)
		{
			labels = new List<string>();
			labels = new List<string>(size);
		}
	}
	
}