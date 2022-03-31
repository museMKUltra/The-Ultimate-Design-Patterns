using System;

namespace DesignPatterns.State
{
    internal class BrushTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("brush mouse down");
        }

        public void MouseUp()
        {
            Console.WriteLine("brush mouse up");
        }
    }
}