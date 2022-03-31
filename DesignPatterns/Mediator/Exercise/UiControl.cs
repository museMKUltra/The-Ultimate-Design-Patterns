using System.Collections.Generic;

namespace DesignPatterns.Mediator.Exercise
{
    public abstract class UiControl
    {
        public delegate void EventHandler();
        
        private List<EventHandler> _eventHandlers = new();

        public void AddEventHandler(EventHandler eventHandler)
        {
            _eventHandlers.Add(eventHandler);
        }

        public void NotifyEventHandlers()
        {
            foreach (var eventHandler in _eventHandlers)
            {
                eventHandler.Invoke();
            }
        }
    }
}