using System;

namespace DesignPatterns.Visitor.Exercise
{
    public class AddReverbVisitor: IVisitor
    {
        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("add reverb - fact");
        }

        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("add reverb - format");
        }
    }
}