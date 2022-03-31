namespace DesignPatterns.Visitor.Exercise
{
    public class FactSegment: ISegment
    {
        public void Execute(IVisitor visitor)
        {
            visitor.Apply(this);
        }
    }
}