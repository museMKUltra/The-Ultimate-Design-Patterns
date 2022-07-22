using System;

namespace DesignPatterns.Composite.Exercise
{
    public class Human: IComponent
    {
        public void Operation()
        {
            Console.WriteLine("human operation");
        }
    }
}