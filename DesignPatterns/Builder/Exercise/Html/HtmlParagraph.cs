namespace DesignPatterns.Builder.Exercise.Html
{
    public class HtmlParagraph : HtmlElement
    {
        private string _text;

        public HtmlParagraph(string text)
        {
            _text = text;
        }

        public override string ToString()
        {
            return $"<p>{_text}</p>";
        }
    }
}