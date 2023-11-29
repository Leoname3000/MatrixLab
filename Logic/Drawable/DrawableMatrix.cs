using System;
namespace Logic
{
	public class DrawableMatrix : ADrawableMatrix
	{
		private IMatrix matrix;
		public int Digits { get; private set; }

		public DrawableMatrix(IMatrix matrix, int digits)
		{
			this.matrix = matrix;
			Digits = digits;
		}

		public override void Draw(IDrawer drawer)
		{
			for (int row = 0; row < matrix.Rows; row++)
			{
				for (int col = 0; col < matrix.Columns; col++)
				{
					drawer.SetPosition(col * (3 + Digits), row);
					matrix.Accept(new DrawItemVisitor(row, col, Digits, drawer));
				}
			}
			drawer.SetPosition(0, DrawableHeight());
		}

		public override int DrawableHeight() => matrix.Rows;
		public override int DrawableWidth() => (3 + Digits) * matrix.Columns - 1;

        public override ADrawableMatrix GetChild() => this;
        public override ADrawableMatrix GetEndpoint() => this;

		// Returnable matrix may be additionally decorated with IMatrix decorators.
		// To retrieve endpoint IMatrix, client should call GetMatrix().GetEndpoint()
        public override IMatrix GetMatrix() => matrix;
        public override void ChangeMatrix(IMatrix matrix) => this.matrix = matrix;
    }
}

