using System;
namespace Logic
{
	public class ColumnSwapperDecorator : IMatrix
	{
		IMatrix child;
		int col1, col2;

		public ColumnSwapperDecorator(IMatrix child, int col1, int col2)
		{
			this.child = child;
			this.col1 = col1;
			this.col2 = col2;
		}

		public int Columns => child.Columns;

		public int Rows => child.Rows;

		public void Accept(IVisitor visitor)
		{
			child.Accept(visitor);
		}

		public double GetItem(int i, int j)
		{
			if (j == col1) j = col2;
			else if (j == col2) j = col1;
			return child.GetItem(i, j);
		}

		public void SetItem(int i, int j, double item)
		{
			if (j == col1) j = col2;
			else if (j == col2) j = col1;
			child.SetItem(i, j, item);
		}

		public IMatrix GetMatrix()
		{
			return child.GetMatrix();
		}
	}
}

