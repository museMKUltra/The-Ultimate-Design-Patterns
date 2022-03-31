using System;
using DesignPatterns.Command.fx;

namespace DesignPatterns.Command
{
    public class BlackAndWhiteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("black and white");
        }
    }
}