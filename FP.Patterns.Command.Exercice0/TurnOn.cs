namespace FP.Patterns.Command.Exercice0
{
    internal class TurnOn : ICommand
    {
        private readonly Device _device;

        public TurnOn(Device device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.TurnOn();
        }

        public void Undo()
        {
            _device.TurnOff();
        }

        public void Redo()
        {
            Execute();
        }
    }
    
}
