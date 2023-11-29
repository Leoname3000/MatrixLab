using System;
namespace Logic
{
	public class DrawItemVisitor : IVisitor
	{
		int row, col;
		int digits;
		IDrawer drawer;

		public DrawItemVisitor(int row, int col, int digits, IDrawer drawer)
		{
			this.row = row;
			this.col = col;
			this.digits = digits;
			this.drawer = drawer;
		}

		public void VisitSimpleMatrix(SimpleMatrix simpleMatrix)
		{
			var item = simpleMatrix.GetItem(row, col);
			drawer.DrawDouble(item, digits);
		}

		public void VisitScatterMatrix(ScatterMatrix scatterMatrix)
		{
			var item = scatterMatrix.GetItem(row, col);
			if (item != 0)
			{
				drawer.DrawDouble(item, digits);
			}
		}

		public void VisitDecorator(ADecorator decorator)
		{
			var (newRow, newCol) = decorator.NewPos(row, col);
			decorator.GetChild().Accept(new DrawItemVisitor(newRow, newCol, digits, drawer));
		}

		public void VisitGroupMatrix(GroupMatrix groupMatrix)
		{
			var (childIndex, childRow, childCol) = groupMatrix.ItemOfChild(row, col);
			if (childIndex >= 0)
			{
				var child = groupMatrix.Children[childIndex];
				child.Accept(new DrawItemVisitor(childRow, childCol, digits, drawer));
			}
		}
	}
}

