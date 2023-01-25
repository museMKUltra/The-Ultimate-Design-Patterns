using System;
using System.Collections.Generic;

namespace DesignPatterns.FactoryMethod.Match
{
    public class Controller
    {
        public void Render(string viewName, Dictionary<string, object> context)
        {
            var engine = CreateViewEngine();
            var html = engine.Render(viewName, context);
            Console.WriteLine(html);
        }

        /*
         * make class be abstract then let subclass overwrite factory method
         */
        // protected abstract IViewEngine CreateViewEngine();

        // virtual method can be overrode
        protected virtual IViewEngine CreateViewEngine()
        {
            return new MatchViewEngine();
        }
    }
}