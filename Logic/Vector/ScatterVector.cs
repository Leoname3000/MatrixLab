using System;
namespace Logic
{
	public class ScatterVector : IVector
	{
		SortedDictionary<int, double> items;

		public ScatterVector(int length)
		{
			items = new SortedDictionary<int, double>();
			Length = length;
		}

		void CheckIndex(int i)
		{
			if (i < 0 || i >= Length) throw new IndexOutOfRangeException();
		}

		public double GetItem(int i)
		{
			CheckIndex(i);
			return items.ContainsKey(i) ? items[i] : 0;
		}

		public void SetItem(int i, double item)
		{
			CheckIndex(i);
			if (item == 0) return;
			items.Add(i, item);
		}

		public int Length { get; private set; }
	}
}

