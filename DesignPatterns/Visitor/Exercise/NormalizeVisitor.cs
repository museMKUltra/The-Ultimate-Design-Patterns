using System;

namespace DesignPatterns.Visitor.Exercise
{
    public class NormalizeVisitor: IVisitor
    {
        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("normalize - fact");
        }

        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("normalize - format");
        }
    }
}