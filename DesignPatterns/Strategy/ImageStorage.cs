using System;

namespace DesignPatterns.Strategy
{
    public class ImageStorage
    {
        private string _compressor;
        private string _filter;

        public ImageStorage(string compressor, string filter)
        {
            _compressor = compressor;
            _filter = filter;
        }

        public void Store(string fileName)
        {
            if (_compressor == "jpeg")
            {
                Console.WriteLine("Compressing using JPEG");
            }
            else if (_compressor == "png")
            {
                Console.WriteLine("Compressing using PNG");
            }

            if (_filter == "b&w")
            {
                Console.WriteLine("Applying B&W filter");
            }
            else if (_filter == "high-contrast")
            {
                Console.WriteLine("Applying high-contrast filter");
            }
        }
    }
}