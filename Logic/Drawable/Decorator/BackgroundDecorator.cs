using System;
namespace Logic
{
	public class BackgroundDecorator : AMatrixDecorator
	{
		public BackgroundDecorator(ADrawableMatrix child) : base(child) {}

		public override void Draw(IDrawer drawer)
		{
			throw new NotImplementedException();
		}

		public override int DrawableHeight()
		{
			return child.DrawableHeight();
		}

		public override int DrawableWidth()
		{
			return child.DrawableWidth();
		}
	}
}

