using System.Collections.Generic;

namespace DesignPatterns.Memento.Exercise
{
    public class DocumentHistory
    {
        private readonly List<DocumentState> _documentStates = new();

        public void Push(DocumentState state)
        {
            _documentStates.Add(state);
        }

        public DocumentState Pop()
        {
            var lastIndex = _documentStates.Count - 1;
            var lastState = _documentStates[lastIndex];
            
            _documentStates.Remove(lastState);
            
            return lastState;
        }
    }
}