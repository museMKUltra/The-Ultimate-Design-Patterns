namespace DesignPatterns.Decorator
{
    public class CompressedCloudStream : IStream
    {
        private IStream _stream;

        public CompressedCloudStream(IStream stream)
        {
            _stream = stream;
        }

        public new void Write(string data)
        {
            var encrypt = Compress(data);
            _stream.Write(encrypt);
        }

        private static string Compress(string data)
        {
            return data.Substring(0, 5);
        }
    }
}