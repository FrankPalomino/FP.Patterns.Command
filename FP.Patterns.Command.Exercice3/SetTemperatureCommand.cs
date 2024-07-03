namespace FP.Patterns.Command.Exercice3
{
    public class SetTemperatureCommand : ICommand
    {
        private readonly Thermostat _thermostat = new();
        public void Execute()
        {
            _thermostat.SetTemperature(20);
        }
    }
}
