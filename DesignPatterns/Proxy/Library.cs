using System;
using System.Collections.Generic;

namespace DesignPatterns.Proxy
{
    public class Library
    {
        private Dictionary<String, IEbook> _ebooks = new();

        public void Add(IEbook ebook)
        {
            _ebooks.Add(ebook.GetFileName(), ebook);
        }
        public void OpenEbook(String fileName)
        {
            _ebooks[fileName].Show();
        }
    }
}