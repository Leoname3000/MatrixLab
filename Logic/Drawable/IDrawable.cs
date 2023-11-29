using System;
namespace Logic
{
	public interface IDrawable
	{
		void Draw(IDrawer drawer);

		int DrawableHeight();
		int DrawableWidth();
	}
}

