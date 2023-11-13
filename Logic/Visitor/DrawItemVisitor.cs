using System;
namespace Logic
{
	public class DrawItemVisitor : IVisitor
	{
		double item;
		int digits;
		IDrawer drawer;

		public DrawItemVisitor(double item, int digits, IDrawer drawer)
		{
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
	}
}

