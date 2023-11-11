using System;
namespace Logic
{
	public abstract class AMatrixDecorator : ADrawableMatrix
	{
		protected ADrawableMatrix child;

		public AMatrixDecorator(ADrawableMatrix matrix) : base(matrix, matrix.Digits)
		{
			this.child = matrix;
		}
	}
}

