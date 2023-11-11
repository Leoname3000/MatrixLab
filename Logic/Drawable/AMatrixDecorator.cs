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

		public override ADrawableMatrix GetMatrix()
		{
			return child.GetMatrix();
		}
	}
}

