using System;

namespace DesignPatterns.Strategy
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("filter b&w");
        }
    }
}