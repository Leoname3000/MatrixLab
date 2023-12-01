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

		public abstract double GetItem(int i, int j);
		public abstract void SetItem(int i, int j, double item);

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

		public abstract void Accept(IVisitor visitor);
	}
}

