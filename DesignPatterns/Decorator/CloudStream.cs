using System;

namespace DesignPatterns.Decorator
{
    public class CloudStream
    {
        public void Write(string data)
        {
            Console.WriteLine($"storing {data}");
        }
    }
}