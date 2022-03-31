using System;

namespace DesignPatterns.Strategy.Exercise
{
    public class DesEncryption : IEncryption
    {
        public void Encrypt(string message)
        {
            Console.WriteLine("Encrypting message using DES");
        }
    }
}