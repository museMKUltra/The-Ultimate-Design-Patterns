using System;

namespace DesignPatterns.FactoryMethod.Exercise
{
    public class ArabianCalendar : ICalendar
    {
        public void AddEvent(Event @event, DateTime dateTime)
        {
            Console.WriteLine("Adding an event to the Arabian calendar");
        }
    }
}