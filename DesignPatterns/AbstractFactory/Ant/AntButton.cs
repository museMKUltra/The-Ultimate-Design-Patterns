using System;

namespace DesignPatterns.AbstractFactory.Ant
{
    public class AntButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Ant Button");
        }
    }
}