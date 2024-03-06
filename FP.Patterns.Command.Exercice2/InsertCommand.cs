namespace FP.Patterns.Command.Exercice2
{
    public class InsertCommand : ICommand
    {
        private TextDocument _document;
        private int _position;
        private string _text;

        public InsertCommand(TextDocument document, int position, string text)
        {
            _document = document;
            _position = position;
            _text = text;
        }
        public void Execute()
        {
            _document.InsertText(_position, _text);
        }

        public void Undo()
        {
            _document.DeleteText(_position, _text.Length);
        }
    }
}
