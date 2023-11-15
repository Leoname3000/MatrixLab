using System;
namespace Logic
{
	public class RowSwapperDecorator : IMatrix
	{
		IMatrix child;
		int row1, row2;

		public RowSwapperDecorator(IMatrix child, int row1, int row2)
		{
			this.child = child;
			this.row1 = row1;
			this.row2 = row2;
		}

		public int Columns => child.Columns;

		public int Rows => child.Rows;

		public void Accept(IVisitor visitor)
		{
			child.Accept(visitor);
		}

		public double GetItem(int i, int j)
		{
			if (i == row1) i = row2;
			else if (i == row2) i = row1;
			return child.GetItem(i, j);
		}

		public void SetItem(int i, int j, double item)
		{
			if (i == row1) i = row2;
			else if (i == row2) i = row1;
			child.SetItem(i, j, item);
        }

        public IMatrix GetMatrix()
        {
            return child.GetMatrix();
        }
    }
}

