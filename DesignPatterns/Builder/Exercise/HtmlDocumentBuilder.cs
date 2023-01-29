using DesignPatterns.Builder.Exercise.Html;

namespace DesignPatterns.Builder.Exercise
{
    public class HtmlDocumentBuilder : IDocumentBuilder
    {
        private HtmlDocument _document = new();

        public void AddImage(Image image)
        {
            _document.Add(new HtmlImage(image.Source));
        }

        public void AddText(Text text)
        {
            _document.Add(new HtmlParagraph(text.Content));
        }

        public string GetResult()
        {
            return _document.ToString();
        }
    }
}