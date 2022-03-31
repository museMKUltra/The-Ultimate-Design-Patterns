using System;
using System.Collections.Generic;

namespace DesignPatterns.Command.Editor
{
    public class History
    {
        private List<IUndoableCommand> _commands = new();

        public void Push(IUndoableCommand undoableCommand)
        {
            _commands.Add(undoableCommand);
        }

        public IUndoableCommand Pop()
        {
            var lastIndex = _commands.Count - 1;
            var lastItem = _commands[lastIndex];

            _commands.RemoveAt(lastIndex);

            return lastItem;
        }

        public int Size()
        {
            return _commands.Count;
        }
    }
}