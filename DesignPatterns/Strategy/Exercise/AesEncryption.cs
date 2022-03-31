using System;

namespace DesignPatterns.Strategy.Exercise
{
    public class AesEncryption : IEncryption
    {
        public void Encrypt(string message)
        {
            Console.WriteLine("Encrypting message using AES");
        }
    }
}