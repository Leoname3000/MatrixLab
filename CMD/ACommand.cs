using System;
namespace CMD
{
    public abstract class ACommand : ICommand
    {
        public abstract void Execute();

        public void Register()
        {
            CM.Instance.Register(this);
        }
    }
}
