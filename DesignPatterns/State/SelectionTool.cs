using System;

namespace DesignPatterns.State
{
    internal class SelectionTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("selection mouse down");
        }

        public void MouseUp()
        {
            Console.WriteLine("selection mouse up");
        }
    }
}