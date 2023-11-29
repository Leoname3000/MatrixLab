using System;
namespace Logic
{
	public abstract class AMatrixDecorator : ADrawableMatrix
	{
		protected ADrawableMatrix child;

		public AMatrixDecorator(ADrawableMatrix child)
		{
			this.child = child;
		}

		public override ADrawableMatrix GetChild() => child;
		public override ADrawableMatrix GetEndpoint() => child.GetEndpoint();

		public override IMatrix GetMatrix() => child.GetMatrix();
		public override void ChangeMatrix(IMatrix matrix) => child.ChangeMatrix(matrix);
	}
}

