using System;

namespace DesignPatterns.Observer.Exercise
{
    public class StockListView : IStock
    {
        private StockSource _stockSource;

        public StockListView(StockSource stockSource)
        {
            _stockSource = stockSource;
        }

        public void Update()
        {
            Console.WriteLine($"stock list view: {_stockSource.Value}");
        }
    }
}