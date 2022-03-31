using System.Collections.Generic;

namespace DesignPatterns.Iterator
{
    public class BrowseHistory
    {
        public List<string> Urls { get; } = new();

        public void Push(string url)
        {
            Urls.Add(url);
        }

        public string Pop()
        {
            var lastIndex = Urls.Count - 1;
            var lastUrl = Urls[lastIndex];

            Urls.RemoveAt(lastIndex);

            return lastUrl;
        }

        public IIterator CreateIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : IIterator
        {
            private readonly BrowseHistory _history;
            private int _index;

            public ListIterator(BrowseHistory history)
            {
                _history = history;
            }

            public void Next()
            {
                _index++;
            }

            public string Current()
            {
                return _history.Urls[_index];
            }

            public bool HasNext()
            {
                return _index < _history.Urls.Count;
            }
        }
    }
}