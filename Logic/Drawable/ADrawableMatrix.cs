using System;
namespace Logic
{
	public abstract class ADrawableMatrix : IDrawable, IMatrix
	{
		IMatrix matrix;

		public ADrawableMatrix(IMatrix matrix, int digits)
		{
			this.matrix = matrix;
			Digits = digits;
		}

		public abstract void Draw(IDrawer drawer);

		public double GetItem(int i, int j)
		{
			return matrix.GetItem(i, j);
		}

		public void SetItem(int i, int j, double item)
		{
			matrix.SetItem(i, j, item);
		}

		public int Digits { get; private set; }

		public int Rows => matrix.Rows;
		public int Columns => matrix.Columns;

		public abstract int DrawableHeight();
		public abstract int DrawableWidth();

		public abstract ADrawableMatrix GetMatrix();
	}
}

