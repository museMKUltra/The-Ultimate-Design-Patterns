using System;

namespace DesignPatterns.State.Exercise
{
    public class Walking : ITravel
    {
        public int Eta => 4;
        public int Direction => 4;

        public int GetEta()
        {
            Console.WriteLine("Calculating ETA (walking)");
            return Eta;
        }

        public int GetDirection()
        {
            Console.WriteLine("Calculating Direction (walking)");
            return Direction;
        }
    }
}