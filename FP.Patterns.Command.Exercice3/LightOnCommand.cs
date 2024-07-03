namespace FP.Patterns.Command.Exercice3
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light = new();
        public void Execute()
        {
            _light.TurnOn();
        }
    }
}
