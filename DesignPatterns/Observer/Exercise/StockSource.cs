using System.Collections.Generic;

namespace DesignPatterns.Observer.Exercise
{
    public class StockSource
    {
        private List<IStock> _stocks = new();
        private int _value;

        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                Notify();
            }
        }

        private void Notify()
        {
            foreach (var stock in _stocks)
            {
                stock.Update();
            }
        }

        public void AddStock(IStock stock)
        {
            _stocks.Add(stock );
        }

        public void RemoveStock(IStock stock)
        {
            _stocks.Remove(stock);
        }
    }
}