namespace DesignPatterns.prototype
{
    public interface IComponent
    {
        void Render();
        IComponent Clone();
    }
}