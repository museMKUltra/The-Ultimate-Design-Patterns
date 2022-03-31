using System;

namespace DesignPatterns.Observer
{
    public class SpreadSheet : IObserver
    {
        private DataSource _dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine($"Spread sheet got notified: {_dataSource.Value}");
        }
    }
}