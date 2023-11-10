using System;
namespace Logic
{
	public class ConsoleDrawer : IDrawer
	{
		char borderChar;
		int originX, originY;

		public ConsoleDrawer(char borderChar)
		{
			this.borderChar = borderChar;
			(originX, originY) = Console.GetCursorPosition();
		}

		public void SetPosition(int x, int y)
		{
			Console.SetCursorPosition(originX + x, originY + y);
		}

		public void MoveOrigin(int deltaX, int deltaY)
		{
			originX += deltaX;
			originY += deltaY;
		}

		public void DrawDouble(double d, int digits)
		{
			var (curX, curY) = Console.GetCursorPosition();
			string format = "0.";
			for (int i = 0; i < digits; i++)
			{
				format += '0';
			}
			var line = d.ToString(format).ToArray();
			for (int i = 0; i < line.Length; i++)
			{
				Console.SetCursorPosition(curX + i, curY);
				Console.Write(line[i]);
			}
			Console.SetCursorPosition(curX, curY);
		}

		public void DrawHorizontalLine(int length)
		{
			var (curX, curY) = Console.GetCursorPosition();
			for (int i = 0; i < length; i++)
			{
				Console.SetCursorPosition(curX + i, curY);
				Console.Write(borderChar);
			}
			Console.SetCursorPosition(curX, curY);
		}

		public void DrawVerticalLine(int length)
		{
			var (curX, curY) = Console.GetCursorPosition();
			for (int i = 0; i < length; i++)
			{
				Console.SetCursorPosition(curX, curY + i);
				Console.Write(borderChar);
			}
			Console.SetCursorPosition(curX, curY);
		}
	}
}

