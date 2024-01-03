namespace FP.Patterns.Command.Exercice1
{
    public class FanOnCommand : ICommand
    {
        private readonly Fan _fan;

        public FanOnCommand(Fan fan)
        {
            _fan = fan;
        }
        public void Execute()
        {
            _fan.TurnOn();
        }
    }
}
