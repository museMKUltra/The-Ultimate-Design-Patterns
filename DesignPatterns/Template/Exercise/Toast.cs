using System;

namespace DesignPatterns.Template.Exercise
{
    public class Toast : Window
    {
        protected override void ExecuteBeforeClose()
        {
            Console.WriteLine("toast before close");
        }

        protected override void ExecuteAfterClose()
        {
            Console.WriteLine("toast after close");
        }
    }
}