namespace Logic;
internal class Program
{
	private static void Main(string[] args)
	{
		var simpleMatrix = new SimpleMatrix(5, 5);
		MatrixFiller.Fill(simpleMatrix, 20, 10);
		MatrixFiller.Print(simpleMatrix);
		var simpleStats = new MatrixStats(simpleMatrix);
		simpleStats.Print();
		Console.WriteLine();

		var scatterMatrix = new ScatterMatrix(5, 5);
		MatrixFiller.Fill(scatterMatrix, 20, 10);
		MatrixFiller.Print(scatterMatrix);
		var scatterStats = new MatrixStats(scatterMatrix);
		scatterStats.Print();
		Console.WriteLine();
	}
}