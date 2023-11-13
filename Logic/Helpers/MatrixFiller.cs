using System;
namespace Logic
{
	public static class MatrixFiller
	{
		public static void Fill(IMatrix matrix, int nonzeroItems, double max, double min = 0)
		{
			int totalItems = matrix.Rows * matrix.Columns;
			if (nonzeroItems > totalItems) throw new IndexOutOfRangeException();
			var randomValues = new double[totalItems];

			var random = new Random();
			for(int i = 0; i < nonzeroItems; i++)
			{
				randomValues[i] = min + random.NextDouble() * (max - min);
			}
			for(int i = nonzeroItems; i < totalItems; i++)
			{
				randomValues[i] = 0;
			}

			randomValues = randomValues.OrderBy(_ => random.Next()).ToArray();
			for(int row = 0; row < matrix.Rows; row++)
			{
				for(int col = 0; col < matrix.Columns; col++)
				{
					matrix.SetItem(row, col, randomValues[row * matrix.Columns + col]);
				}
			}
		}

		public static void Print(IMatrix matrix)
		{
			for(int row = 0; row < matrix.Rows; row++)
			{
				for(int col = 0; col < matrix.Columns; col++)
				{
					Console.Write($"{matrix.GetItem(row, col)} ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}

