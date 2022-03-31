using System;

namespace DesignPatterns.Mediator.Observer
{
    public class ListBox : UiControl
    {
        private string _selection;

        public string Selection
        {
            get => _selection;
            set
            {
                _selection = value;
                NotifyEventHandlers();
            }
        }
    }
}