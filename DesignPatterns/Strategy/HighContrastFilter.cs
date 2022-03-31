using System;

namespace DesignPatterns.Strategy
{
    public class HighContrastFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("filter high-contrast");
        }
    }
}