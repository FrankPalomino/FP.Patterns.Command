namespace FP.Patterns.Command.Exercice3
{
    public class FanOffCommand : ICommand
    {
        private readonly Fan _fan = new();

        public void Execute()
        {
            _fan.TurnOff();
        }
    }
}
