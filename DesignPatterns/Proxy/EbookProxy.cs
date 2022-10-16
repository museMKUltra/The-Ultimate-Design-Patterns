using System;

namespace DesignPatterns.Proxy
{
    public class EbookProxy : IEbook
    {
        private String _fileName;
        private RealEbook _ebook;

        public EbookProxy(String fileName)
        {
            _fileName = fileName;
        }
        public void Show()
        {
            _ebook ??= new RealEbook(_fileName);
            _ebook.Show();
        }

        public string GetFileName()
        {
            return _fileName;
        }
    }
}