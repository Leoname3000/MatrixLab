using System;
namespace Logic
{
	public abstract class AModifyingDecorator : ADecorator
	{
		public AModifyingDecorator(IMatrix child) : base(child) {}

		public override int Columns => child.Columns;
		public override int Rows => child.Rows;

		public override void Accept(IVisitor visitor)
		{
			visitor.VisitModifyingDecorator(this);
		}
	}
}

