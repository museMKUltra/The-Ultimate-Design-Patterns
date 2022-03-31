namespace DesignPatterns.ChainOfResponsibility.Exercise
{
    public abstract class DataHandler
    {
        private readonly DataHandler _next;

        protected DataHandler(DataHandler next)
        {
            _next = next;
        }

        public void Handle(DataFiles dataFiles)
        {
            if (DoHandle(dataFiles)) return;

            _next?.Handle(dataFiles);
        }

        protected abstract bool DoHandle(DataFiles dataFiles);
    }
}