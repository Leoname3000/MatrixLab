using System;
namespace Logic
{
	public class DrawableScatter : ADrawableMatrix
	{
		public DrawableScatter(ScatterMatrix matrix, int digits) : base(matrix, digits) {}

		public override void Draw(IDrawer drawer)
		{
			for (int row = 0; row < Rows; row++)
			{
				for (int col = 0; col < Columns; col++)
				{
					var item = GetItem(row, col);
					if (item != 0)
					{ 
						drawer.SetPosition(col * (3 + Digits), row);
						drawer.DrawDouble(GetItem(row, col), Digits);
					}
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
	}
}

