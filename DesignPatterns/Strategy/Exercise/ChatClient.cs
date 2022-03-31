using System;

namespace DesignPatterns.Strategy.Exercise
{
    public class ChatClient
    {
        private readonly IEncryption _encryption;

        public ChatClient(IEncryption encryption)
        {
            _encryption = encryption;
        }

        public void Send(string message)
        {
            Console.WriteLine($"Sending the encrypted message: {message}");
            _encryption.Encrypt(message);
        }
    }
}