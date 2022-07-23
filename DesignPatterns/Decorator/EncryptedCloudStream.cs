namespace DesignPatterns.Decorator
{
    public class EncryptedCloudStream : CloudStream
    {
        public new void Write(string data)
        {
            var encrypt = Encrypt(data);
            base.Write(encrypt);
        }

        private static string Encrypt(string data)
        {
            return "!@#$%^&*";
        }
    }
}