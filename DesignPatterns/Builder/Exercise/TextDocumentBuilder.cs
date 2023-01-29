using System.Text;

namespace DesignPatterns.Builder.Exercise
{
    public class TextDocumentBuilder : IDocumentBuilder
    {
        private StringBuilder _builder = new();

        public void AddImage(Image image)
        {
            // Note that this method has no implementation because
            // images cannot be added to a plain text file.
        }

        public void AddText(Text text)
        {
            _builder.Append(text.Content);
        }

        public string GetResult()
        {
            return _builder.ToString();
        }
    }
}