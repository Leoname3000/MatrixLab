using System;
namespace Logic
{
	public class PlusDecorator : AModifyingDecorator
	{
		double toPlus;

		public PlusDecorator(double toPlus, IMatrix child) : base(child)
		{
			this.toPlus = toPlus;
		}

		public override double GetItem(int row, int col)
		{
			return child.GetItem(row, col) + toPlus;
		}

		public override void SetItem(int row, int col, double item)
		{
			child.SetItem(row, col, item - toPlus);
		}
	}
}

