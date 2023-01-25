using System;

namespace DesignPatterns.FactoryMethod.Exercise
{
    public class Calendar
    {
        public void AddEvent(Event @event, DateTime today)
        {
            Console.WriteLine("Adding an event on the given date.");
        }
    }
}