using System;

namespace DesignPatterns.FactoryMethod.Exercise
{
    public class Scheduler
    {
        private readonly ICalendar _calendar;

        public Scheduler()
        {
            _calendar = CreateCalendar();
        }

        protected virtual ICalendar CreateCalendar()
        {
            return new GregorianCalendar();
        }
        
        public void Schedule(Event @event) {
            var today = new DateTime();
            _calendar.AddEvent(@event, today);
        }
    }
}