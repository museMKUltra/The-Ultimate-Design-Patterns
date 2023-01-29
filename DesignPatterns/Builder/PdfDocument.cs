using System;

namespace DesignPatterns.Builder
{
    public class PdfDocument
    {
        public void AddPage(string text)
        {
            Console.WriteLine("Adding a page to PDF");
        }
    }
}