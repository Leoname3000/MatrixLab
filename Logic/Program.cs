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

		IMatrix first = new ScatterMatrix(7, 5);
		MatrixFiller.Fill(first, 20, 10);
		ADrawableMatrix firstDrawable = new DrawableMatrix(first, 2);
		firstDrawable = new BorderDecorator(new BorderDecorator(firstDrawable));
		firstDrawable.Draw(new ConsoleDrawer('#'));

		Console.WriteLine();

		IMatrix second = first;
		//second = new MultiplyDecorator(0.5, second);
		second = new TransposeDecorator(second);
        ADrawableMatrix secondDrawable = new DrawableMatrix(second, 2);
		secondDrawable = new BorderDecorator(new BorderDecorator(secondDrawable));
		secondDrawable.Draw(new ConsoleDrawer('+'));

		Console.WriteLine();

		IMatrix group = new GroupMatrix(new List<IMatrix>{ first, second });
		//group = new PlusDecorator(0.01, group);
		group = new TransposeDecorator(group);
		ADrawableMatrix groupDrawable = new DrawableMatrix(group, 2);
		groupDrawable = new BorderDecorator(new SpacerDecorator(groupDrawable));
        groupDrawable.Draw(new ConsoleDrawer('$'));
	}
}