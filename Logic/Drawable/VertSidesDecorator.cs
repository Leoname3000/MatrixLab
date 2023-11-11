using System;
namespace Logic
{
	public class VertSidesDecorator : AMatrixDecorator
	{
		public VertSidesDecorator(ADrawableMatrix matrix) : base(matrix) {}

		public override void Draw(IDrawer drawer)
		{
			drawer.SetPosition(0, 0);
			drawer.DrawVerticalLine(DrawableHeight());
			drawer.SetPosition(DrawableWidth() - 1, 0);
			drawer.DrawVerticalLine(DrawableHeight());
			drawer.MoveOrigin(1, 0);
			drawer.SetPosition(0, 0);
			child.Draw(drawer);
			drawer.MoveOrigin(-1, 0);
			drawer.SetPosition(0, DrawableHeight());
		}

		public override int DrawableHeight()
		{
			return child.DrawableHeight();
		}

		public override int DrawableWidth()
		{
			return child.DrawableWidth() + 2;
		}
	}
}

