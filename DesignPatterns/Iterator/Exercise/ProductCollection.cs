using System.Collections.Generic;

namespace DesignPatterns.Iterator.Exercise
{
    public class ProductCollection
    {
        public List<Product> Products = new();

        public void Add(Product product)
        {
            Products.Add(product);
        }

        public IIterator CreateIterator()
        {
            return new ProductIterator(this);
        }

        public class ProductIterator : IIterator
        {
            private int _index;
            private readonly ProductCollection _productCollection;

            public ProductIterator(ProductCollection productCollection)
            {
                _productCollection = productCollection;
            }

            public void Next()
            {
                _index++;
            }

            public string Current()
            {
                return _productCollection.Products[_index].ToString();
            }

            public bool HasNext()
            {
                return _index < _productCollection.Products.Count;
            }
        }
    }
}