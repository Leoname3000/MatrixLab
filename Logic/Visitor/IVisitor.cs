using System;
namespace Logic
{
	public interface IVisitor
	{
		void VisitSimpleMatrix(SimpleMatrix simpleMatrix);
		void VisitScatterMatrix(ScatterMatrix scatterMatrix);
		void VisitDecorator(ADecorator decorator);
		void VisitGroupMatrix(GroupMatrix groupMatrix);
	}
}

