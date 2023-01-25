using System.Collections.Generic;
using DesignPatterns.FactoryMethod.Match;

namespace DesignPatterns.FactoryMethod.Sharp
{
    public class SharpViewEngine : IViewEngine
    {
        public string Render(string viewName, Dictionary<string, object> context)
        {
            return "View rendered by Sharp";
        }
    }
}