using System;
namespace Logic
{
	public class SpacerDecorator : AMatrixDecorator
	{
		public SpacerDecorator(ADrawableMatrix child) : base(child) { }

		public override void Draw(IDrawer drawer)
		{
			drawer.SetPosition(0, 0);
			drawer.MoveOrigin(2, 1);
			drawer.SetPosition(0, 0);
			child.Draw(drawer);
			drawer.MoveOrigin(-2, -1);
			drawer.SetPosition(0, DrawableHeight());
		}

		public override int DrawableHeight() => child.DrawableHeight() + 2;
		public override int DrawableWidth() => child.DrawableWidth() + 4;
	}
}

