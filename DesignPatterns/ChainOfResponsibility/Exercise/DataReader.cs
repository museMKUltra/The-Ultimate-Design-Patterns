namespace DesignPatterns.ChainOfResponsibility.Exercise
{
    public class DataReader
    {
        private DataHandler _handler;

        public DataReader(DataHandler handler)
        {
            _handler = handler;
        }

        public void Read(DataFiles dataFiles)
        {
            _handler.Handle(dataFiles);
        }
    }
}