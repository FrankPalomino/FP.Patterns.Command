namespace FP.Patterns.Command.Exercice4
{
    public class GarageDoor
    {
        private string _door = string.Empty;
        public void OpenGarageDoor()
        {
            _door = "Open";
        }

        public void CloseGarageDoor()
        {
            _door = "Close";
        }

        public void GarageDoorState()
        {
            Console.WriteLine($"The Garage Door is {_door}");
        }
    }
}
