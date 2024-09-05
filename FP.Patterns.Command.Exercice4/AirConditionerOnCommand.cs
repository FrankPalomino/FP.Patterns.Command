namespace FP.Patterns.Command.Exercice4
{
    public class AirConditionerOnCommand : ICommand
    {
        private readonly AirConditioner _airConditioner;

        public AirConditionerOnCommand(AirConditioner airConditioner)
        {
            _airConditioner = airConditioner;
        }

        public void Execute()
        {
            _airConditioner.OnAirConditioner();
        }

        public void Redo()
        {
            _airConditioner.OnAirConditioner();
        }

        public void Undo()
        {
            _airConditioner.OffAirConditioner();
        }
    }
}
