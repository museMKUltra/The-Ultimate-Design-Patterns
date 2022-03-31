using System;

namespace DesignPatterns.Template.Exercise
{
    public class Dialog : Window
    {
        protected override void ExecuteBeforeClose()
        {
            Console.WriteLine("dialog before close");
        }

        protected override void ExecuteAfterClose()
        {
            Console.WriteLine("dialog after close");
        }
    }
}