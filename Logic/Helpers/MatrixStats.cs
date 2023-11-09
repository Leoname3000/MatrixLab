using System;
namespace Logic
{
	public class MatrixStats
	{
		IMatrix matrix;

		public MatrixStats(IMatrix matrix)
		{
			this.matrix = matrix;
			Sum = 0;
			Max = double.MinValue;
			NonzeroItems = 0;
			for(int row = 0; row < matrix.Rows; row++)
			{
				for(int col = 0; col < matrix.Columns; col++)
				{
					var item = matrix.GetItem(row, col);
					Sum += item;
					if (Max < item) Max = item;
					if (item != 0) NonzeroItems++;
				}
			}
		}

		public double Sum { get; private set; }

		public double Average => Sum / (matrix.Rows * matrix.Columns);

		public double Max { get; private set; }

		public double NonzeroItems { get; private set; }

		public void Print()
		{
			Console.WriteLine($"Sum: {Sum}");
			Console.WriteLine($"Avg: {Average}");
			Console.WriteLine($"Max: {Max}");
			Console.WriteLine($"Nonzero: {NonzeroItems}");
		}
	}
}

