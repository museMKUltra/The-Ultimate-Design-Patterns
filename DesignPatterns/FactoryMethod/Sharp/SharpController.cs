using DesignPatterns.FactoryMethod.Match;

namespace DesignPatterns.FactoryMethod.Sharp
{
    public class SharpController : Controller
    {
        protected override IViewEngine CreateViewEngine()
        {
            return new SharpViewEngine();
        }
    }
}