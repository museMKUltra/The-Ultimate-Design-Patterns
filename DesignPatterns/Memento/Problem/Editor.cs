namespace DesignPatterns.Memento.Problem
{
    /* how to do an undo feature in this class */
    public class Editor
    {
        private string _content;

        public string GetContent()
        {
            return _content;
        }

        public void SetContent(string content)
        {
            _content = content;
        }
    }
}