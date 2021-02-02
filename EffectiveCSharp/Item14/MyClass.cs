using System;
using System.Collections.Generic;
using System.Text;

namespace EffectiveCSharp.Item14
{
	public class MyClass
	{
		private List<ImportantData> coll;

		private string name;

		public MyClass() : this(0,string.Empty)
		{
		}

		public MyClass(int initialCount = 0, string name = "")
		{
			coll = initialCount > 0 ? new List<ImportantData>(initialCount) : new List<ImportantData>();
			this.name = name;
		}

		public void addImportantData(ImportantData importantData)
		{
			if (importantData == null)
			{
				throw new ArgumentNullException();
			}

			coll.Add(importantData);
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append($"name : {name}");
			coll.ForEach(data =>
			{
				sb.Append($"{data}");
			});
			return sb.ToString();

		}
	}

	public record ImportantData
	{
		public string Name { get;  }
		public DateTime RegsterDateTime { get; }

		public ImportantData(string name, DateTime regsterDateTime)
		{
			Name = name;
			RegsterDateTime = regsterDateTime;
		}
	}
}