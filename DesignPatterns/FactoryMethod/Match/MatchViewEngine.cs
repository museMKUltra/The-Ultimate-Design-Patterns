using System.Collections.Generic;

namespace DesignPatterns.FactoryMethod.Match
{
    public class MatchViewEngine
    {
        public string Render(string viewName, Dictionary<string, object> context)
        {
            return "View rendered by Matcha";
        }
    }
}