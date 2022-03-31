using System.Collections.Generic;
using DesignPatterns.Command.fx;

namespace DesignPatterns.Command
{
    public class CompositeCommand : ICommand
    {
        private readonly List<ICommand> _commands = new();

        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void AddCommand(ICommand command)
        {
           _commands.Add(command); 
        }
    }
}