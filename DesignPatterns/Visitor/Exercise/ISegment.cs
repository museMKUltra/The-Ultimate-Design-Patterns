namespace DesignPatterns.Visitor.Exercise
{
    public interface ISegment
    {
        public void Execute(IVisitor visitor);
    }
}