using System.Collections.Generic;

namespace DesignPatterns.Mediator.Observer
{
    public delegate void EventHandler();

    public abstract class UiControl
    {
        private List<EventHandler> _eventHandlers = new();

        public void AddEventHandler(EventHandler eventHandler)
        {
            _eventHandlers.Add(eventHandler);
        }

        protected void NotifyEventHandlers()
        {
            foreach (var eventHandler in _eventHandlers)
            {
                eventHandler.Invoke();
            }
        }
    }
}