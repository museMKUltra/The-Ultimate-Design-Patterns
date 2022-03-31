namespace DesignPatterns.Mediator.Exercise
{
    public class CheckBox : UiControl
    {
        private bool _isChecked;

        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                _isChecked = value;
                NotifyEventHandlers();
            }
        }    }
}