using System;

namespace DesignPatterns
{
    public class VividFilter : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("apply vivid filter");
        }
    }
}