using System;
namespace Logic
{
	public abstract class ARenumberingDecorator : ADecorator
	{
		public ARenumberingDecorator(IMatrix child) : base(child) {}

		public abstract (int, int) NewPos(int row, int col);

		public override double GetItem(int i, int j)
		{
			var (newRow, newCol) = NewPos(i, j);
			return child.GetItem(newRow, newCol);
		}

		public override void SetItem(int i, int j, double item)
		{
			var (newRow, newCol) = NewPos(i, j);
			child.SetItem(newRow, newCol, item);
		}

		public override void Accept(IVisitor visitor)
		{
			visitor.VisitRenumberingDecorator(this);
		}
	}
}

