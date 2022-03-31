using System;

namespace DesignPatterns.State.Exercise
{
    public class DirectionService
    {
        public TravelMode Mode { get; set; }

        public int GetEta()
        {
            if (Mode == TravelMode.Driving)
            {
                Console.WriteLine("Calculating ETA (driving)");
                return 1;
            }
            else if (Mode == TravelMode.Bicycling)
            {
                Console.WriteLine("Calculating ETA (bicycling)");
                return 2;
            }
            else if (Mode == TravelMode.Transit)
            {
                Console.WriteLine("Calculating ETA (transit)");
                return 3;
            }
            else
            {
                Console.WriteLine("Calculating ETA (walking)");
                return 4;
            }
        }

        public int GetDirection()
        {
            if (Mode == TravelMode.Driving)
            {
                Console.WriteLine("Calculating Direction (driving)");
                return 1;
            }
            else if (Mode == TravelMode.Bicycling)
            {
                Console.WriteLine("Calculating Direction (bicycling)");
                return 2;
            }
            else if (Mode == TravelMode.Transit)
            {
                Console.WriteLine("Calculating Direction (transit)");
                return 3;
            }
            else
            {
                Console.WriteLine("Calculating Direction (walking)");
                return 4;
            }
        }
    }
}
