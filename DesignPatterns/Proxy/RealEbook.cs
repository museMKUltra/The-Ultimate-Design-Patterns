using System;

namespace DesignPatterns.Proxy
{
    public class Ebook : IEbook
    {
        private String _fileName;

        public Ebook(String fileName)
        {
            _fileName = fileName;
            Load();
        }

        public void Load()
        {
            Console.WriteLine("Loading the ebook " + _fileName);
        }

        public void Show()
        {
            Console.WriteLine("Showing the ebook " + _fileName);
        }

        public String GetFileName()
        {
            return _fileName;
        }
    }
}