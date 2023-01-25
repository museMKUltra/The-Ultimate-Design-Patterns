using System;

namespace DesignPatterns.FactoryMethod.Exercise
{
    public interface ICalendar
    {
        public void AddEvent(Event @event, DateTime dateTime);
    }
}