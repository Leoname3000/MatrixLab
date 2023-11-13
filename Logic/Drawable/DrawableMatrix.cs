using System;
namespace Logic
{
	public class DrawableMatrix : ADrawableMatrix
	{
		public DrawableMatrix(IMatrix matrix, int digits) : base(matrix, digits) {}

		public override void Draw(IDrawer drawer)
		{
			for (int row = 0; row < Rows; row++)
			{
				for (int col = 0; col < Columns; col++)
				{
					var item = GetItem(row, col);
					drawer.SetPosition(col * (3 + Digits), row);
					matrix.Accept(new DrawItemVisitor(item, Digits, drawer));
				}
			}
		}

		public override int DrawableHeight()
		{
			return Rows;
		}

		public override int DrawableWidth()
		{
			return (3 + Digits) * Columns - 1;
		}

		protected internal override void DrawItem(int i, int j, IDrawer drawer)
		{
			throw new NotImplementedException();
		}

		public override ADrawableMatrix GetMatrix()
		{
			return this;
		}
	}
}

