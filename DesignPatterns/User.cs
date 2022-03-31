using System;

namespace DesignPatterns
{
    public class User
    {
        // Fields (attributes)
        public string Name;

        public User(string name)
        {
            Name = name;
        }

        // Methods
        public void SayHello()
        {
            Console.WriteLine($"Hi, my name is {Name}");
        }
    }
}