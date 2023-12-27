using System;
using Logic;

namespace CMD
{
    public class CmdPutItem : ACommand
    {
        IMatrix matrix;
        int row, col;
        double item;

        public CmdPutItem(IMatrix matrix, int row, int col, double item)
        {
            this.matrix = matrix;
            this.row = row;
            this.col = col;
            this.item = item;
        }

        public override void Execute()
        {
            matrix.SetItem(row, col, item);
        }
    }
}
