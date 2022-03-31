namespace DesignPatterns.State.Exercise
{
    public interface ITravel
    {
        int Eta { get; }
        int Direction { get; }
        public int GetEta();
        public int GetDirection();
    }
}