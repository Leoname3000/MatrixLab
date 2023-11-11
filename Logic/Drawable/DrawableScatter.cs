using System;
namespace Logic
{
	public class DrawableScatter : ADrawableMatrix
	{
		public DrawableScatter(ScatterMatrix child, int digits) : base(child, digits) {}

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
						drawer.DrawDouble(item, Digits);
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

		public override ADrawableMatrix GetMatrix()
		{
			return this;
		}
	}
}

