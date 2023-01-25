using System.Collections.Generic;

namespace DesignPatterns.FactoryMethod.Match
{
    public interface IViewEngine
    {
        string Render(string viewName, Dictionary<string, object> context);
    }
}