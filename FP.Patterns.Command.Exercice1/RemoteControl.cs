namespace FP.Patterns.Command.Exercice1
{
    public class RemoteControl
    {
        private List<ICommand> _commands = new List<ICommand>();

        public void SetCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void PressButton()
        {
            if (_commands.Count > 0)
            {
                var command = _commands[0];
                command.Execute();
                _commands.Remove(command);
            }
            else
            {
                Console.WriteLine("No Command found");
            }
        }
    }
}
