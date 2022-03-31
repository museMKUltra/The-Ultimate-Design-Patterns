using System;

namespace DesignPatterns.State.Exercise
{
    public class Bicycling : ITravel
    {
        public int Eta => 2;
        public int Direction => 2;

        public int GetEta()
        {
            Console.WriteLine("Calculating ETA (bicycling)");
            return Eta;
        }

        public int GetDirection()
        {
            Console.WriteLine("Calculating Direction (bicycling)");
            return Direction;
        }
    }
}