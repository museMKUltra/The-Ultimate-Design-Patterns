using DesignPatterns.Builder.Exercise.Html;

namespace DesignPatterns.Builder.Exercise
{
    public class HtmlDocumentBuilder : IDocumentBuilder
    {
        private HtmlDocument _document = new();

        public void Add(IElement element)
        {
            if (element is Text text)
            {
                _document.Add(new HtmlParagraph(text.Content));
            }
            else if (element is Image image)
            {
                _document.Add(new HtmlImage(image.Source));
            }
        }

        public string GetContent()
        {
            return _document.ToString();
        }
    }
}