using System;
namespace Logic
{
	public class DrawableSimple : ADrawableMatrix
	{
		public DrawableSimple(SimpleMatrix matrix, int digits) : base(matrix, digits) {}

		public override void Draw(IDrawer drawer)
		{
			for (int row = 0; row < Rows; row++)
			{
				for (int col = 0; col < Columns; col++)
				{
					drawer.SetPosition(col * (3 + Digits), row);
					drawer.DrawDouble(GetItem(row, col), Digits);
				}
			}
			//drawer.SetPosition(0, Rows);
		}

		public override int DrawableHeight()
		{
			return Rows;
		}
		public override int DrawableWidth()
		{
			return (3 + Digits) * Columns - 1;
		}
	}
}

