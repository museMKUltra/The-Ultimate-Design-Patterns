using System;

namespace DesignPatterns.Proxy.Exercise
{
    public class ProductProxy : IProduct
    {
        private readonly Product _product;
        private readonly DbContext _dbContext;

        public int Id => _product.Id;

        public string Name
        {
            get => _product.Name;
            set
            {
                _dbContext.MarkAsChanged(this);
                _product.Name = value;
            }
        }

        public ProductProxy(Product product, DbContext dbContext)
        {
            _product = product;
            _dbContext = dbContext;
        }
    }
}