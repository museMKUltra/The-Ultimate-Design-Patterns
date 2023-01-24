using System;

namespace DesignPatterns.prototype
{
    public class Circle : Component
    {
        public int Radius { get; set; }

        public void Render()
        {
            Console.WriteLine("Rendering a circle");
        }
    }
}