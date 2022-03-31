
using System;
using DesignPatterns.Command.fx;

namespace DesignPatterns.Command
{
    public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("resize");
        }
    }
}