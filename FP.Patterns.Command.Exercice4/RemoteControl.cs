namespace FP.Patterns.Command.Exercice4
{
    public class RemoteControl
    {
        private ICommand _command;
        private Stack<ICommand> _stack;
        public RemoteControl(ICommand command)
        {
            _command = command;
            _stack = new Stack<ICommand>();
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
            _stack.Push(_command);
        }

        public void UnDoCommand()
        {
            var command = _stack.Pop();
            command.Undo();
        }

        public void ReDoCommand()
        {
            _command.Execute();
        }
    }
}
