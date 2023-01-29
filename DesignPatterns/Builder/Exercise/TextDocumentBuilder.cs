using System.Text;

namespace DesignPatterns.Builder.Exercise
{
    public class TextDocumentBuilder : IDocumentBuilder
    {
        private StringBuilder _builder = new();

        public void Add(IElement element)
        {
            if (element is Text text)
            {
                _builder.Append(text.Content);
            }
        }

        public string GetContent()
        {
            return _builder.ToString();
        }
    }
}