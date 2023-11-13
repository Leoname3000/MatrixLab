using System;
namespace Logic
{
	public class TransposeDecorator : AMatrixDecorator
	{
		public TransposeDecorator(ADrawableMatrix child) : base(child) {}

		public override void Draw(IDrawer drawer)
		{
			child.Draw(drawer);
		}

		public override void DrawItem(int row, int col, IDrawer drawer)
		{
			child.DrawItem(col, row, drawer);
		}

		public override int DrawableHeight()
		{
			return child.DrawableWidth();
		}

		public override int DrawableWidth()
		{
			return child.DrawableHeight();
		}
	}
}

