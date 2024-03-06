namespace FP.Patterns.Command.Exercice2
{
    public class DeleteCommand : ICommand
    {
        private TextDocument _document;
        private int _position;
        private string _deletedText;

        public DeleteCommand(TextDocument document, int position, int length)
        {
            _document = document;
            _position = position;
            _deletedText = _document.Content.Substring(position, length);
        }

        public void Execute()
        {
            _document.DeleteText(_position, _deletedText.Length);
        }

        public void Undo()
        {
            _document.InsertText(_position, _deletedText);
        }
    }
}
