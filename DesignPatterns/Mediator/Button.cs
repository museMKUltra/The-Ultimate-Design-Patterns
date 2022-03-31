namespace DesignPatterns.Mediator
{
    public class Button : UiControl
    {
        private bool _isEnabled;

        public Button(DialogBox dialogBox) : base(dialogBox)
        {
        }

        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                _owner.Changed(this);
            }
        }
    }
}