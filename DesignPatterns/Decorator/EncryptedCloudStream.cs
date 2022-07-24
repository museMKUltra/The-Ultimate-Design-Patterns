namespace DesignPatterns.Decorator
{
    public class EncryptedCloudStream : IStream
    {
        private IStream _stream;

        public EncryptedCloudStream(IStream stream)
        {
            _stream = stream;
        }

        public new void Write(string data)
        {
            var encrypt = Encrypt(data);
            _stream.Write(encrypt);
        }

        private static string Encrypt(string data)
        {
            return "!@#$%^&*";
        }
    }
}