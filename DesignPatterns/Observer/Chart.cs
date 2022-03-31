using System;

namespace DesignPatterns.Observer
{
    public class Chart : IObserver
    {
        private DataSource _dataSource;

        public Chart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine($"Chart got updated: {_dataSource.Value}");
        }
    }
}