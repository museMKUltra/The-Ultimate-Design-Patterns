using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.Exercise.Html
{
    public class HtmlDocument
    {
        private List<HtmlElement> _elements = new();

        public void Add(HtmlElement element)
        {
            _elements.Add(element);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append("<html>");
            
            foreach (var htmlElement in _elements)
            {
                builder.Append(htmlElement);
            }
            builder.Append("</html>");

            return builder.ToString();
        }
    }
}