using System;
namespace Logic
{
	public class SimpleVector : IVector
	{
		double[] items;

		public SimpleVector(int length)
		{
			items = new double[length];
		}

		public double GetItem(int i) => items[i];

		public void SetItem(int i, double item)
		{
			items[i] = item;
		}

		public int Length => items.Length;
	}
}

