using System;
namespace Logic
{
	public interface IDecoratable<T>
	{
		T GetChild();
		T GetEndpoint();
	}
}

