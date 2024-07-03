namespace FP.Patterns.Command.Exercice3
{
    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void Execute()
        {
            _command.Execute();
        }
    }
}
