﻿using System;
namespace Logic
{
	public abstract class AMatrix : IMatrix
	{
		IVector[] rowArray;

		public AMatrix(int rows, int columns)
		{
			Columns = columns;
			rowArray = new IVector[rows];
			for(int r = 0; r < rows; r++)
			{
				rowArray[r] = CreateVector();
			}
		}

		protected abstract IVector CreateVector();

		public double GetItem(int i, int j) => rowArray[i].GetItem(j);

		public void SetItem(int i, int j, double item)
		{
			rowArray[i].SetItem(j, item);
		}

		public int Rows => rowArray.Length;

		public int Columns { get; private set; }

		public abstract void Accept(IVisitor visitor);

		public IMatrix GetMatrix()
		{
			return this;
		}
	}
}

