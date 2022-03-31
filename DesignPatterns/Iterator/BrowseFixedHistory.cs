namespace DesignPatterns.Iterator
{
    public class BrowseFixedHistory
    {
        private const int FixedLength = 10;
        private string[] Urls { get; }
        public int Count { get; set; }

        public BrowseFixedHistory()
        {
            Urls = new string[FixedLength];
        }

        public void Push(string url)
        {
            if (Count == FixedLength)
            {
                for (var i = 1; i < Urls.Length; i++)
                {
                    Urls[i - 1] = Urls[i];
                }

                Count -= 1;
            }

            Urls[Count++] = url;
        }

        public string Pop()
        {
            if (Count == 0)
            {
                return "";
            }

            return Urls[--Count];
        }

        public IIterator CreateIterator()
        {
            return new ArrayIterator(this);
        }

        private class ArrayIterator : IIterator
        {
            private readonly BrowseFixedHistory _history;
            private int _index;

            public ArrayIterator(BrowseFixedHistory history)
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
                return _index < _history.Count;
            }
        }
    }
}