namespace FP.Patterns.Command.Exercice4
{
    public class AirConditionerOffCommand : ICommand
    {
        private readonly AirConditioner _airConditioner;

        public AirConditionerOffCommand(AirConditioner airConditioner)
        {
            _airConditioner = airConditioner;
        }

        public void Execute()
        {
            _airConditioner.OffAirConditioner();
        }

        public void Redo()
        {
            _airConditioner.OffAirConditioner();
        }

        public void Undo()
        {
            _airConditioner.OnAirConditioner();
        }
    }
}
