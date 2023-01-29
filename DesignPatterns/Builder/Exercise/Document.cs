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
            // Note that we've separated the construction of the target
            // document from its representation. The same construction
            // algorithm is used to generate different types of documents
            // such as HTML, text, etc.

            // For text files, even though we don't have images, we still
            // use the same algorithm. Look at the implementation of
            // addImage() method in TextDocumentBuilder. It's empty. So it
            // simply ignores adding images.

            foreach (var element in _elements)
            {
                if (element is Text text)
                {
                    builder.AddText(text);
                }
                else if (element is Image image)
                {
                    builder.AddImage(image);
                }
            }

            var content = builder.GetResult();
            var writer = new StreamWriter(fileName);
            writer.Write(content);
            writer.Close();
        }
    }
}