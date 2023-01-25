using System;

namespace DesignPatterns.FactoryMethod.Exercise
{
    public class Scheduler
    {
        private Calendar _calendar = new();
        
        public void Schedule(Event @event) {
            var today = new DateTime();
            _calendar.AddEvent(@event, today);
        }
    }
}