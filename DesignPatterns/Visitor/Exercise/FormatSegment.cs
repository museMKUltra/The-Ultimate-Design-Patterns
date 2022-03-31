namespace DesignPatterns.Visitor.Exercise
{
    public class FormatSegment: ISegment
    {
        public void Execute(IVisitor visitor)
        {
            visitor.Apply(this);
        }
    }
}