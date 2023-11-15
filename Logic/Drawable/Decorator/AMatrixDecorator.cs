using System;
namespace Logic
{
	public abstract class AMatrixDecorator : ADrawableMatrix
	{
		protected ADrawableMatrix child;

		public AMatrixDecorator(ADrawableMatrix child) : base(child, child.Digits)
		{
			this.child = child;
		}

		//protected override void DrawItem(IDrawer drawer)
		//{
		//	AMatrixDecorator g = (AMatrixDecorator)child;
		//	g.DrawItem(drawer);
		//}

		protected internal override void DrawItem(int i, int j, IDrawer drawer)
		{
			child.DrawItem(i, j, drawer);
		}

        public override ADrawableMatrix GetChild()
        {
			return child;
        }

        public override ADrawableMatrix GetMatrix()
		{
			return child.GetMatrix();
		}

		public override void ChangeMatrix(IMatrix matrix)
		{
			child.ChangeMatrix(matrix);
		}
	}
}

