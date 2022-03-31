using System.Collections.Generic;

namespace DesignPatterns.Visitor
{
    public class HtmlDocument
    {
        public List<IHtmlNode> Nodes { get; } = new();

        public void Execute(IOperation operation)
        {
            foreach (var node in Nodes)
            {
                node.Execute(operation);
            }
        }
    }
}