namespace DesignPatterns.Mediator.Observer
{
    public class Button : UiControl
    {
        private bool _isEnabled;

        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                NotifyEventHandlers();
            }
        }
    }
}