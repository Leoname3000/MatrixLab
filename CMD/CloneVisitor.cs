using System;
using Logic;

namespace CMD
{
    public class CloneVisitor : IVisitor
    {
        IMatrix? clone;

        public CloneVisitor(IMatrix matrix)
        {
            matrix.Accept(this);
        }

        public void VisitGroupMatrix(GroupMatrix groupMatrix)
        {
            clone = new GroupMatrix(new List<IMatrix>());
        }

        public void VisitModifyingDecorator(AModifyingDecorator modifyingDecorator)
        {
            modifyingDecorator.GetChild().Accept(this);
        }

        public void VisitRenumberingDecorator(ARenumberingDecorator renumberingDecorator)
        {
            renumberingDecorator.GetChild().Accept(this);
        }

        public void VisitScatterMatrix(ScatterMatrix scatterMatrix)
        {
            clone = new ScatterMatrix(scatterMatrix.Rows, scatterMatrix.Columns);
        }

        public void VisitSimpleMatrix(SimpleMatrix simpleMatrix)
        {
            clone = new SimpleMatrix(simpleMatrix.Rows, simpleMatrix.Columns);
        }

        public IMatrix Clone()
        {
            if (clone == null) return new SimpleMatrix(1, 1);
            return clone;
        }
    }
}
