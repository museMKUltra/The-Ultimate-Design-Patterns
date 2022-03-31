namespace DesignPatterns.Mediator
{
    public class TextBox : UiControl
    {
        private string _content;

        public TextBox(DialogBox dialogBox) : base(dialogBox)
        {
        }

        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                _owner.Changed(this);
            }
        }
    }
}