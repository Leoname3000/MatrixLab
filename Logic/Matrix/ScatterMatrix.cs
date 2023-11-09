using System;
namespace Logic
{
	public class ScatterMatrix : AMatrix
	{
		public ScatterMatrix(int rows, int columns) : base(rows, columns) {}

		protected override IVector CreateVector() => new ScatterVector(Columns);
	}
}

