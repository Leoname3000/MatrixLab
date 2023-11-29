using System;
namespace Logic
{
	public class VertSidesDecorator : AMatrixDecorator
	{
		public VertSidesDecorator(ADrawableMatrix child) : base(child) {}

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

		public override int DrawableHeight() => child.DrawableHeight();
		public override int DrawableWidth() => child.DrawableWidth() + 2;
	}
}

