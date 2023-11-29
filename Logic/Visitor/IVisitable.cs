using System;
namespace Logic
{
	public interface IVisitable
	{
		void Accept(IVisitor visitor);
	}
}

