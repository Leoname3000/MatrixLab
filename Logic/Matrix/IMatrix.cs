using System;
namespace Logic
{
	public interface IMatrix : IDecoratable<IMatrix>, IVisitable
	{
		double GetItem(int i, int j);
		void SetItem(int i, int j, double item);

		int Columns { get; }
		int Rows { get; }
	}
}

