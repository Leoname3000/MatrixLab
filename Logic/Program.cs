namespace Logic;
internal class Program
{
	private static void Main(string[] args)
	{
		//var simpleMatrix = new SimpleMatrix(5, 5);
		//MatrixFiller.Fill(simpleMatrix, 20, 10);
		////MatrixFiller.Print(simpleMatrix);
		////var simpleStats = new MatrixStats(simpleMatrix);
		////simpleStats.Print();
		////Console.WriteLine();

		//var scatterMatrix = new ScatterMatrix(5, 5);
		//MatrixFiller.Fill(scatterMatrix, 20, 10);
		////MatrixFiller.Print(scatterMatrix);
		////var scatterStats = new MatrixStats(scatterMatrix);
		////scatterStats.Print();
		////Console.WriteLine();

		//ADrawableMatrix scatterDrawable = new DrawableScatter(scatterMatrix, 2);
		//scatterDrawable = new TransposeDecorator(scatterDrawable);

		//scatterDrawable.GetMatrix().Draw(new ConsoleDrawer('#'));
		//Console.WriteLine();
		//Console.WriteLine();
		//scatterDrawable.Draw(new ConsoleDrawer('+'));

		var first = new ScatterMatrix(7, 5);
		MatrixFiller.Fill(first, 20, 10);
		ADrawableMatrix firstDrawable = new DrawableMatrix(first, 2);
		firstDrawable = new BorderDecorator(new BorderDecorator(firstDrawable));
		firstDrawable.Draw(new ConsoleDrawer('#'));

		Console.WriteLine();

		var second = new TransposeDecorator(first);
		//var second = first;
		ADrawableMatrix secondDrawable = new DrawableMatrix(second, 2);
		secondDrawable = new BorderDecorator(new BorderDecorator(secondDrawable));
		secondDrawable.Draw(new ConsoleDrawer('+'));

		Console.WriteLine();

		var group = new GroupMatrix();
		group.AddMatrix(first);
		group.AddMatrix(second);
		var tgroup = new TransposeDecorator(group);
		ADrawableMatrix groupDrawable = new BorderDecorator(new DrawableMatrix(tgroup, 2));
		groupDrawable.Draw(new ConsoleDrawer('$'));
	}
}