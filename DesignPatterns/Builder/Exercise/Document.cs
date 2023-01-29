using System;
using System.Collections.Generic;
using System.IO;
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

        public void Export(IDocumentBuilder builder, string fileName)
        {
            foreach (var element in _elements)
            {
                builder.Add(element);
            }

            var content = builder.GetContent();
            var writer = new StreamWriter(fileName);
            Console.WriteLine($"{fileName}: {content}");
            writer.Write(content);
            writer.Close();
        }
    }
}