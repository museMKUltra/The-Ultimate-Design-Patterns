namespace DesignPatterns.prototype.exercise
{
    public class Clip : IComponent
    {
        public IComponent Clone()
        {
            return new Clip();
        }
    }
}