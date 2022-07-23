namespace DesignPatterns.Decorator
{
    public class CompressedCloudStream : CloudStream
    {
        public new void Write(string data)
        {
            var encrypt = Compress(data);
            base.Write(encrypt);
        }

        private static string Compress(string data)
        {
            return data.Substring(0, 5);
        }
    }
}