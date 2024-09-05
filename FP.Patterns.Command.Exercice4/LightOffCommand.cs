namespace FP.Patterns.Command.Exercice4
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.OffLight();
        }

        public void Redo()
        {
            _light.OffLight();
        }

        public void Undo()
        {
            _light.OnLight();
        }
    }
}
