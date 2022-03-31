using System;

namespace DesignPatterns.Observer.Exercise
{
    public class StatusBar : IStock
    {
        private StockSource _stockSource;

        public StatusBar(StockSource stockSource)
        {
            _stockSource = stockSource;
        }

        public void Update()
        {
            Console.WriteLine($"status bar: {_stockSource.Value}");
        }
    }
}