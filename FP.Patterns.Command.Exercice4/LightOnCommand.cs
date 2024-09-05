namespace FP.Patterns.Command.Exercice4
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.OnLight();
        }

        public void Redo()
        {
            _light.OnLight();
        }

        public void Undo()
        {
            _light.OffLight();
        }
    }
}
