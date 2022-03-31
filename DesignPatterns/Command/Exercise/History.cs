using System.Collections.Generic;

namespace DesignPatterns.Command.Exercise
{
    public class History
    {
        private List<IUndoableCommand> _commands = new();

        public int Size()
        {
            return _commands.Count;
        }

        public void Push(IUndoableCommand command)
        {
            _commands.Add(command);
        }

        public IUndoableCommand Pop()
        {
            var lastIndex = _commands.Count - 1;
            var lastItem = _commands[lastIndex];
            
            _commands.RemoveAt(lastIndex);

            return lastItem;
        }
    }
}