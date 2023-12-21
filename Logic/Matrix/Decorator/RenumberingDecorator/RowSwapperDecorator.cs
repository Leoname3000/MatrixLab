using System;
namespace Logic
{
	public class RowSwapperDecorator : ARenumberingDecorator
	{
		int row1, row2;

		public RowSwapperDecorator(int row1, int row2, IMatrix child) : base(child)
		{
			this.row1 = row1;
			this.row2 = row2;
		}

		public override (int, int) NewPos(int row, int col)
		{
			if (row == row1) row = row2;
			else if (row == row2) row = row1;
			return (row, col);
		}

		public override int Columns => child.Columns;
		public override int Rows => child.Rows;
    }
}

