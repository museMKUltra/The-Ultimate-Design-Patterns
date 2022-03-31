using System;

namespace DesignPatterns.State
{
    internal class EraserTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("eraser mouse down");
        }

        public void MouseUp()
        {
            Console.WriteLine("eraser mouse up");
        }
    }
}