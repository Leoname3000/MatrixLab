using System;
namespace Logic
{
	public abstract class ADecorator : IMatrix
	{
		protected IMatrix child;

		public ADecorator(IMatrix child)
		{
			this.child = child;
		}

		public abstract (int, int) NewPos(int row, int col);

		public double GetItem(int i, int j)
		{
			var (newRow, newCol) = NewPos(i, j);
			return child.GetItem(newRow, newCol);
		}

		public void SetItem(int i, int j, double item)
		{
			var (newRow, newCol) = NewPos(i, j);
			child.SetItem(newRow, newCol, item);
		}

		public abstract int Columns { get; }
		public abstract int Rows { get; }

		public IMatrix GetChild()
		{
			return child;
		}

		public IMatrix GetEndpoint()
		{
			return child.GetEndpoint();
		}

		public void Accept(IVisitor visitor)
		{
			visitor.VisitDecorator(this);
		}
	}
}

