namespace DesignPatterns.Builder.Exercise.Html
{
    public class HtmlImage : HtmlElement
    {
        private readonly string _source;

        public HtmlImage(string source)
        {
            _source = source;
        }

        public override string ToString()
        {
            return $"<img src=\"{_source}\" />";
        }
    }
}