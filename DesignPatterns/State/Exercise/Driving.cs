using System;

namespace DesignPatterns.State.Exercise
{
    public class Driving : ITravel
    {
        public int Eta => 1;
        public int Direction => 1;

        public int GetEta()
        {
            Console.WriteLine("Calculating ETA (driving)");
            return Eta;
        }

        public int GetDirection()
        {
            Console.WriteLine("Calculating Direction (driving)");
            return Direction;
        }
    }
}