using System;
namespace Logic
{
	public class TransposeDecorator : IMatrix
	{
		IMatrix child;

		public TransposeDecorator(IMatrix child)
		{
			this.child = child;
		}

		public int Columns => child.Rows;

		public int Rows => child.Columns;

		public void Accept(IVisitor visitor)
		{
			child.Accept(visitor);
		}

		public double GetItem(int i, int j)
		{
			return child.GetItem(j, i);
		}

		public void SetItem(int i, int j, double item)
		{
			child.SetItem(j, i, item);
		}
	}
}

