using System;
namespace Logic
{
	public interface IDrawer
	{
		void SetPosition(int x, int y);
		void MoveOrigin(int deltaX, int deltaY);
		void DrawDouble(double d, int digits);
		void DrawHorizontalLine(int length);
		void DrawVerticalLine(int length);
		void DrawBox(int width, int height);
	}
}

