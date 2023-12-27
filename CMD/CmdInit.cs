using System;
using Logic;

namespace CMD
{
    public class CmdInit : ACommand
    {
        IMatrix initMatrix;
        IMatrix matrix;

        public CmdInit(IMatrix matrix)
        {
            this.matrix = matrix; 
            MatrixFiller.Fill(matrix, 20, 10);
            var cloneVisitor = new CloneVisitor(matrix);
            matrix.Accept(cloneVisitor);
            initMatrix = cloneVisitor.Clone();
        }

        public override void Execute()
        {
            var cloneVisitor = new CloneVisitor(initMatrix);
            matrix.Accept(cloneVisitor);
            matrix = cloneVisitor.Clone();
        }
    }
}
