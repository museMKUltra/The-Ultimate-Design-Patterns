using System;

namespace DesignPatterns.prototype
{
    public class Circle : IComponent
    {
        public int Radius { get; set; }

        public void Render()
        {
            Console.WriteLine("Rendering a circle");
        }

        public IComponent Clone()
        {
            return new Circle { Radius = Radius };
        }
    }
}