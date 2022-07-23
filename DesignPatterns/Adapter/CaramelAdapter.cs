namespace DesignPatterns.Adapter
{
    public class CaramelAdapter: Caramel, IFilter
    {
        public void Apply(Image image)
        {
            Init();
            Render(image);
        }
    }
}