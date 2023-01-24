namespace DesignPatterns.prototype.exercise
{
    public class Audio : IComponent
    {
        public IComponent Clone()
        {
            return new Audio();
        }
    }
}