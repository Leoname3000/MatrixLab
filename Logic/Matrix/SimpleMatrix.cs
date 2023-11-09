using System;
namespace Logic
{
	public class SimpleMatrix : AMatrix
	{
		public SimpleMatrix(int rows, int columns) : base(rows, columns) {}

		protected override IVector CreateVector() => new SimpleVector(Columns);
	}
}

