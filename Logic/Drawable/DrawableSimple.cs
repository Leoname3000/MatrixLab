using System;
namespace Logic
{
	public class DrawableSimple : ADrawableMatrix
	{
		public DrawableSimple(SimpleMatrix child, int digits) : base(child, digits) {}

		public override void Draw(IDrawer drawer)
		{
			for (int row = 0; row < Rows; row++)
			{
				for (int col = 0; col < Columns; col++)
				{
					DrawItem(row, col, drawer);
				}
			}
		}

		protected internal override void DrawItem(int row, int col, IDrawer drawer)
		{
			drawer.SetPosition(col * (3 + Digits), row);
			drawer.DrawDouble(GetItem(row, col), Digits);
		}

		public override int DrawableHeight()
		{
			return Rows;
		}

		public override int DrawableWidth()
		{
			return (3 + Digits) * Columns - 1;
		}

		public override ADrawableMatrix GetMatrix()
		{
			return this;
		}
	}
}

