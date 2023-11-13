using System;
namespace Logic
{
	public interface IVisitor
	{
		void VisitSimpleMatrix(SimpleMatrix simpleMatrix);
		void VisitScatterMatrix(ScatterMatrix scatterMatrix);
	}
}

