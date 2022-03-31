namespace DesignPatterns.Mediator.Observer
{
    public class TextBox : UiControl
    {
        private string _content;

        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                NotifyEventHandlers();
            }
        }
    }
}