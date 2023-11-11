using System;
namespace Logic
{
	public class HorSidesDecorator : AMatrixDecorator
	{
		public HorSidesDecorator(ADrawableMatrix matrix) : base(matrix) { }

		public override void Draw(IDrawer drawer)
		{
			drawer.SetPosition(0, 0);
			drawer.DrawHorizontalLine(DrawableWidth());
			drawer.SetPosition(0, DrawableHeight() - 1);
			drawer.DrawHorizontalLine(DrawableWidth());
			drawer.MoveOrigin(0, 1);
			drawer.SetPosition(0, 0);
			child.Draw(drawer);
			drawer.MoveOrigin(0, -1);
			drawer.SetPosition(0, DrawableHeight());
		}

		public override int DrawableHeight()
		{
			return child.DrawableHeight() + 2;
		}

		public override int DrawableWidth()
		{
			return child.DrawableWidth();
		}
	}
}

