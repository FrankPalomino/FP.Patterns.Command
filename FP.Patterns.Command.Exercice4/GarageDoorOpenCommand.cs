namespace FP.Patterns.Command.Exercice4
{
    public class GarageDoorOpenCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.OpenGarageDoor();
        }

        public void Redo()
        {
            _garageDoor.OpenGarageDoor();
        }

        public void Undo()
        {
            _garageDoor.CloseGarageDoor();
        }
    }
}
