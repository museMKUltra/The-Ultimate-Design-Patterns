using System.Collections.Generic;

namespace DesignPatterns.Iterator
{
    public interface IIterator
    {
        public void Next();
        public string Current();
        public bool HasNext();
    }

}