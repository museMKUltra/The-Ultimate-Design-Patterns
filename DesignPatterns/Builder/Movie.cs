using System;

namespace DesignPatterns.Builder
{
    public class Movie
    {
        public void AddFrame(string text, int duration)
        {
            Console.WriteLine("Adding a frame to the movie");
        }
    }
}