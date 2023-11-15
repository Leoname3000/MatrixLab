using System;
namespace Logic
{
	public interface IMatrix
	{
		double GetItem(int i, int j);
		void SetItem(int i, int j, double item);
		int Columns { get; }
		int Rows { get; }
		void Accept(IVisitor visitor);
		IMatrix GetMatrix();
    }
}

