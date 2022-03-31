using System;

namespace DesignPatterns.State.Exercise
{
    public class Transit : ITravel
    {
        public int Eta => 3;
        public int Direction => 3;

        public int GetEta()
        {
            Console.WriteLine("Calculating ETA (transit)");
            return Eta;
        }

        public int GetDirection()
        {
            Console.WriteLine("Calculating Direction (transit)");
            return Direction;
        }
    }
}