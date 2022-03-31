using System;

namespace DesignPatterns.Template.Exercise
{
    public abstract class Window
    {
        public void Close()
        {
            ExecuteBeforeClose();

            Console.WriteLine("Removing the window from the screen");

            ExecuteAfterClose();
        }

        protected abstract void ExecuteBeforeClose();

        protected abstract void ExecuteAfterClose();
    }
}