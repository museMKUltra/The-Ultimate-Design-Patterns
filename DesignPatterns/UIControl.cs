using System;

namespace DesignPatterns
{
    public abstract class UIControl
    {
        public void Enable()
        {
            Console.WriteLine("Enable");
        }

        public abstract void Draw();
    }
}