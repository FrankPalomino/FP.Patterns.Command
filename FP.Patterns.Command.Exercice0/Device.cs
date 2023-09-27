namespace FP.Patterns.Command.Exercice0
{
    internal class Device
    {
        private string Name { get;}
        private bool IsOn;

        public Device(string name)
        {
            Name = name;
            IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
            System.Console.WriteLine($"{Name} is on");
        }

        public void TurnOff()
        {
            IsOn = false;
            System.Console.WriteLine($"{Name} is off");
        }
    }
}
