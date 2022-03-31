using DesignPatterns.State.Abuse;

namespace DesignPatterns.Strategy
{
    public class ImageStorage2
    {
        public static void Store(string fileName, ICompressor compressor, IFilter filter)
        {
            compressor.Compress(fileName);
            filter.Apply(fileName);
        }
    }
}