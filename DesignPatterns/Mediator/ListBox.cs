namespace DesignPatterns.Mediator
{
    public class ListBox : UiControl
    {
        private string _selection;

        public ListBox(DialogBox dialogBox) : base(dialogBox)
        {
        }

        public string Selection
        {
            get => _selection;
            set
            {
                _selection = value;
                _owner.Changed(this);
            }
        }
    }
}