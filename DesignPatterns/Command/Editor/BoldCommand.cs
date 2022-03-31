namespace DesignPatterns.Command.Editor
{
    public class BoldCommand : IUndoableCommand
    {
        private string _prevContent;
        private HtmlDocument _document;
        private History _history;

        public BoldCommand(HtmlDocument document, History history)
        {
            _document = document;
            _history = history;
        }

        public void Execute()
        {
            _prevContent = _document.Content;
            _document.MakeBold();
            _history.Push(this);
        }

        public void Unexecute()
        {
            _document.Content = _prevContent;
        }
    }
}