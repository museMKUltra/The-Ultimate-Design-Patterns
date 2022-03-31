using System.Collections.Generic;

namespace DesignPatterns
{
    public class History
    {
        private List<EditorState> _states = new();

        public void Push(EditorState state)
        {
            _states.Add(state);
        }

        public EditorState Pop()
        {
            var lastIndex = _states.Count -1;
            var lastState = _states[lastIndex];

            _states.Remove(lastState);
            return lastState;
        }
    }
}