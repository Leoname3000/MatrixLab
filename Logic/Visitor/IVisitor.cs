using System;
namespace Logic
{
	public interface IVisitor
	{
		void VisitSimpleMatrix(SimpleMatrix simpleMatrix);
		void VisitScatterMatrix(ScatterMatrix scatterMatrix);
		void VisitGroupMatrix(GroupMatrix groupMatrix);
		void VisitRenumberingDecorator(ARenumberingDecorator renumberingDecorator);
		void VisitModifyingDecorator(AModifyingDecorator modifyingDecorator);
	}
}

