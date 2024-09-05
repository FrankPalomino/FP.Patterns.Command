namespace FP.Patterns.Command.Exercice4
{
    public class Light
    {
        private string _on = string.Empty;
        public void OnLight()
        {
            _on = "On";
        }

        public void OffLight()
        {
            _on = "Off";
        }

        public void LightState()
        {
            Console.WriteLine($"The Light is {_on}");
        }
    }
}
