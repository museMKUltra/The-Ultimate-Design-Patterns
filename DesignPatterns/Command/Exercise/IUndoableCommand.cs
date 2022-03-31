namespace DesignPatterns.Command.Exercise
{
    public interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}