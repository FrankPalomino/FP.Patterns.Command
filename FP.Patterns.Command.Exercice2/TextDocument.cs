namespace FP.Patterns.Command.Exercice2
{
    public class TextDocument
    {
        public string Content { get; set; } = string.Empty;

        public void InsertText(int position, string text)
        {
            Content = Content.Insert(position, text);
        }

        public void DeleteText(int position, int length)
        {
            Content = Content.Remove(position, length);
        }
    }
}
