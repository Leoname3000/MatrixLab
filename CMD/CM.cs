using System;
namespace CMD
{
    public class CM
    {
        static CM? singleton;
        List<ICommand> history;

        private CM()
        {
            history = new List<ICommand>();
        }

        public static CM Instance
        {
            get
            {
                if (singleton == null)
                    singleton = new CM();
                return singleton;
            }
        }

        public void Register(ICommand command)
        {
            history.Add(command);
        }

        public void Undo()
        {
            if (history.Count <= 1) return;
            history.RemoveAt(history.Count - 1);
            foreach (var command in history)
                command.Execute();
        }
    }
}
