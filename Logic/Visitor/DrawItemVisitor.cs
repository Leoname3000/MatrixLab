using System;
namespace Logic
{
	public class DrawItemVisitor : IVisitor
	{
		int row, col;
		double item;
		int digits;
		IDrawer drawer;

		public DrawItemVisitor(int row, int col, double item, int digits, IDrawer drawer)
		{
			this.row = row;
			this.col = col;
			this.item = item;
			this.digits = digits;
			this.drawer = drawer;
		}

		public void VisitSimpleMatrix(SimpleMatrix simpleMatrix)
		{
			drawer.DrawDouble(item, digits);
		}

		public void VisitScatterMatrix(ScatterMatrix scatterMatrix)
		{
			if (item != 0)
			{
				drawer.DrawDouble(item, digits);
			}
		}

		public void VisitGroupMatrix(GroupMatrix groupMatrix)
		{
			var (childIndex, childRow, childCol) = groupMatrix.ItemOfChild(row, col);
			(row, col) = (childRow, childCol);
			if (childIndex >= 0)
			{
				var child = groupMatrix.GetChild(childIndex);
				child.Accept(this);
			}
		}

		public void VisitRenumberingDecorator(ARenumberingDecorator renumberingDecorator)
		{
			(row, col) = renumberingDecorator.NewPos(row, col);
			renumberingDecorator.GetChild().Accept(this);
		}

		public void VisitModifyingDecorator(AModifyingDecorator modifyingDecorator)
		{
			modifyingDecorator.GetChild().Accept(this);
		}
	}
}

