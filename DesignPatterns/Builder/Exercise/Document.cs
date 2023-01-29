using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using DesignPatterns.Builder.Exercise.Html;

namespace DesignPatterns.Builder.Exercise
{
    public class Document
    {
        private List<IElement> _elements = new();

        public void Add(IElement element)
        {
            _elements.Add(element);
        }

        public void Export(ExportFormat format, string fileName)
        {
            var content = "";

            if (format == ExportFormat.Html)
            {
                var document = new HtmlDocument();

                foreach (var element in _elements)
                {
                    if (element is Text text)
                    {
                        document.Add(new HtmlParagraph(text.Content));
                    }
                    else if (element is Image image)
                    {
                        document.Add(new HtmlImage(image.Source));
                    }
                }

                content = document.ToString();
            }
            else if (format == ExportFormat.Text)
            {
                var builder = new StringBuilder();

                foreach (var element in _elements)
                {
                    if (element is Text text)
                    {
                        builder.Append(text.Content);
                    }
                }

                content = builder.ToString();
            }

            var writer = new StreamWriter(fileName);
            writer.Write(content);
            writer.Close();
        }
    }
}