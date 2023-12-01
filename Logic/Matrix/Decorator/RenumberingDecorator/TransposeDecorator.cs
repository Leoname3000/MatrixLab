using System;
namespace Logic
{
	public class TransposeDecorator : ARenumberingDecorator
	{
		public TransposeDecorator(IMatrix child) : base(child)
		{
			this.child = child;
		}

		public override (int, int) NewPos(int row, int col)
		{
			return (col, row);
		}

		public override int Columns => child.Rows;
		public override int Rows => child.Columns;
	}
}

