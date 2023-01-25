using System;

namespace DesignPatterns.AbstractFactory.Ant
{
    public class AntTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Ant TextBox");
        }
    }
}