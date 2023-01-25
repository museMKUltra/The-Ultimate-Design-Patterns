using System;

namespace DesignPatterns.FactoryMethod.Exercise
{
    public class GregorianCalendar : ICalendar
    {
        public void AddEvent(Event @event, DateTime dateTime)
        {
            Console.WriteLine("Adding an event on the given date.");
        }
    }
}