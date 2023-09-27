namespace FP.Patterns.Command.Exercice0
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
        void Redo();
    }
}
