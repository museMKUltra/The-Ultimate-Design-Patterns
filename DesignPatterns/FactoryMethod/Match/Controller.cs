using System;
using System.Collections.Generic;

namespace DesignPatterns.FactoryMethod.Match
{
    public class Controller
    {
        public void Render(string viewName, Dictionary<string, object> context)
        {
            var engine = new MatchViewEngine();
            var html = engine.Render(viewName, context);
            Console.WriteLine(html);
        }
    }
}