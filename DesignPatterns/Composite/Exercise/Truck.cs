using System;

namespace DesignPatterns.Composite.Exercise
{
    public class Truck: IComponent
    {
        public void Operation()
        {
            Console.WriteLine("truck operation");
        }
    }
}