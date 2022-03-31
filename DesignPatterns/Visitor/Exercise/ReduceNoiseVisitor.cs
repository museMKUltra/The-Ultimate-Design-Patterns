using System;

namespace DesignPatterns.Visitor.Exercise
{
    public class ReduceNoiseVisitor : IVisitor
    {
        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("reduce noise - fact");
        }

        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("reduce noise - format");
        }
    }
}