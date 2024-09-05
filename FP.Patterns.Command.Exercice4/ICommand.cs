namespace FP.Patterns.Command.Exercice4
{
    public interface ICommand
    {
        void Execute();
        void Undo();
        void Redo();
    }
}
