namespace FP.Patterns.Command.Exercice4
{
    public class AirConditioner
    {
        private string _on = string.Empty;
        public void OnAirConditioner()
        {
            _on = "On";
        }

        public void OffAirConditioner()
        {
            _on = "Off";
        }

        public void AirConditionerState()
        {
            Console.WriteLine($"The Air Conditioner is {_on}");
        }
    }
}
