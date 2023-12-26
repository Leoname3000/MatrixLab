using System;
namespace Logic
{
    public class VerticalGroupMatrix : GroupMatrix
    {

        public VerticalGroupMatrix(List<IMatrix> children) : base(children)
        {
            for (int childIdx = 0; childIdx < Children.Count; childIdx++) 
            {
                Children[childIdx] = new TransposeDecorator(Children[childIdx]);
            }
        }

        public override void AddMatrix(IMatrix matrix)
        {
            base.AddMatrix(new TransposeDecorator(matrix));
        }

        public override (int, int, int) ItemOfChild(int row, int col)
        {
            return base.ItemOfChild(col, row);
        }

        public override int Columns => base.Rows;
        public override int Rows => base.Columns;
    }
}
