namespace DesignPatterns.Visitor.Exercise
{
    public interface IVisitor
    {
        public void Apply(FactSegment factSegment);
        public void Apply(FormatSegment formatSegment);
    }
}