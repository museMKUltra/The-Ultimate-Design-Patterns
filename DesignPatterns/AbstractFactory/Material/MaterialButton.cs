using System;

namespace DesignPatterns.AbstractFactory.Material
{
    public class MaterialButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Material Button");
        }
    }
}