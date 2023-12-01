using System;
namespace Logic
{
	public class ColumnSwapperDecorator : ARenumberingDecorator
	{
		int col1, col2;

		public ColumnSwapperDecorator(int col1, int col2, IMatrix child) : base(child)
		{
			this.col1 = col1;
			this.col2 = col2;
		}

		public override (int, int) NewPos(int row, int col)
		{
			if (col == col1) col = col2;
			else if (col == col2) col = col1;
			return (row, col);
		}

		public override int Columns => child.Columns;
		public override int Rows => child.Rows;
	}
}

