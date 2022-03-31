using System.Collections.Generic;

namespace DesignPatterns.Visitor.Exercise
{
    public class WaveFile
    {
        private readonly List<ISegment> _segments = new();

        public List<ISegment> Segments => _segments;

        public void Execute(IVisitor visitor)
        {
            foreach (var segment in Segments)
            {
                segment.Execute(visitor);
            }
        }
    }
}