using System;

namespace DesignPatterns.Composite
{
    public class Shape : IComponent
    {
        public void Render()
        {
            Console.WriteLine("render shape");
        }

        public void Move()
        {
            Console.WriteLine("move shape");
        }
    }
}