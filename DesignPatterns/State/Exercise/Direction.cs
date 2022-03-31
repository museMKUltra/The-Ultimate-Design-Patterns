namespace DesignPatterns.State.Exercise
{
    public class Direction
    {
        public ITravel CurrentTravel { get; set; }

        public int GetEta()
        {
            return CurrentTravel.GetEta();
        }

        public int GetDirection()
        {
            return CurrentTravel.GetDirection();
        }
    }
}