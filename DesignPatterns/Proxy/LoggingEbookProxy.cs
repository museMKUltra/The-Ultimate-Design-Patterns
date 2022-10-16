using System;

namespace DesignPatterns.Proxy
{
    public class LoggingEbookProxy : IEbook
    {
        private String _fileName;
        private RealEbook _ebook;

        public LoggingEbookProxy(string fileName)
        {
            _fileName = fileName;
        }

        public void Show()
        {
            _ebook ??= new RealEbook(_fileName);

            Console.WriteLine($"Logging");
            _ebook.Show();
        }

        public string GetFileName()
        {
            return _fileName;
        }
    }
}