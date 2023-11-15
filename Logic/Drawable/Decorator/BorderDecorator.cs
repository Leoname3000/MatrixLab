using System;
namespace Logic
{
	public class BorderDecorator : AMatrixDecorator
	{

		public BorderDecorator(ADrawableMatrix matrix) : base(matrix){}

		public override void Draw(IDrawer drawer)
		{
			drawer.SetPosition(0, 0);
			drawer.DrawBox(DrawableWidth(), DrawableHeight());
			drawer.MoveOrigin(1, 1);
			drawer.SetPosition(0, 0);
			child.Draw(drawer);
			drawer.MoveOrigin(-1, -1);
			drawer.SetPosition(0, DrawableHeight());
		}

		public override int DrawableHeight()
		{
			return child.DrawableHeight() + 2;
		}
		public override int DrawableWidth()
		{
			return child.DrawableWidth() + 2;
		}
	}
}

