using System;

namespace EffectiveCSharp.Item20
{
	public struct Customer : IComparable<Customer>, IComparable
	{
		private readonly string name;

		public Customer(string name)
		{
			this.name = name;
		}

		public int CompareTo(Customer other) => string.Compare(name, other.name, StringComparison.Ordinal);

		public int CompareTo(object obj)
		{
			if (!(obj is Customer))
			{
				throw new ArgumentException("argument is not Customer");
			}

			var otherCustomer = (Customer) obj;

			return CompareTo(otherCustomer);
		}

		public static bool operator <(Customer left, Customer right) => left.CompareTo(right) < 0;
		public static bool operator >(Customer left, Customer right) => left.CompareTo(right) > 0;
		public static bool operator <=(Customer left, Customer right) => left.CompareTo(right) <= 0;
		public static bool operator >=(Customer left, Customer right) => left.CompareTo(right) >= 0;
	}
}