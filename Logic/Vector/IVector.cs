using System;
namespace Logic
{
	public interface IVector
	{
		double GetItem(int i);
		void SetItem(int i, double item);
		int Length { get; }
	}
}

