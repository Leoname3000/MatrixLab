using System;
namespace Logic
{
	public class GroupMatrix : IMatrix
	{
		public List<IMatrix> Children { get; protected set; }

		public GroupMatrix(List<IMatrix> children)
		{
			Children = children;
		}

		public void AddMatrix(IMatrix matrix)
		{
			Children.Add(matrix);
		}

		public (int, int, int) ItemOfChild(int row, int col)
		{
			for (int childIdx = 0; childIdx < Children.Count; childIdx++)
			{
				if (col >= Children[childIdx].Columns)
					col -= Children[childIdx].Columns;
				else
				{
					if (row < Children[childIdx].Rows)
						return (childIdx, row, col);
					break;
				}
			}
			return (-1, row, col);
		}

		public double GetItem(int row, int col)
		{
			int childIdx, childRow, childCol;
			(childIdx, childRow, childCol) = ItemOfChild(row, col);
			if (childIdx >= 0)
				return Children[childIdx].GetItem(childRow, childCol);
			else
				return 0;
		}

		public void SetItem(int row, int col, double item)
		{
			int childIdx, childRow, childCol;
			(childIdx, childRow, childCol) = ItemOfChild(row, col);
			if (childIdx >= 0)
				Children[childIdx].SetItem(childRow, childCol, item);
		}

		public int Columns
		{
			get
			{
				int sum = 0;
				foreach (var m in Children)
				{
					sum += m.Columns;
				}
				return sum;
			}
		}

		public int Rows
		{
			get
			{
				int max = 0;
				foreach (var m in Children)
				{
					if (max < m.Rows)
						max = m.Rows;
				}
				return max;
			}
		}

		public IMatrix GetChild()
		{
			return this;
		}

		public IMatrix GetEndpoint()
		{
			return this;
		}

		public void Accept(IVisitor visitor)
		{
			visitor.VisitGroupMatrix(this);
		}
	}
}

