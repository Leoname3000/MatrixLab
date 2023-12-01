using System;
namespace Logic
{
	public class MultiplyDecorator : AModifyingDecorator
	{
		double toMult;

		public MultiplyDecorator(double toMult, IMatrix child) : base(child)
		{
			this.toMult = toMult;
		}

		public override double GetItem(int row, int col)
		{
			return child.GetItem(row, col) * toMult;
		}

		public override void SetItem(int row, int col, double item)
		{
			if (toMult != 0)
				item = item / toMult;
			child.SetItem(row, col, item);
		}
	}
}

