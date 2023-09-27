namespace FP.Patterns.Command.Exercice0
{
    internal class RemoteControl
    {
        private ICommand _currentRemote;

        public void SetCommand(ICommand command)
        {
            _currentRemote = command;
        }

        public void PressButton()
        {
            _currentRemote?.Execute();
        }
    }
}
