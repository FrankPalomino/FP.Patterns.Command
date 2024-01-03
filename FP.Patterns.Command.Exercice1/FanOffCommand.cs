namespace FP.Patterns.Command.Exercice1
{
    public class FanOffCommand : ICommand
    {
        private readonly Fan _fan;

        public FanOffCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.TurnOff();
        }
    }
}
