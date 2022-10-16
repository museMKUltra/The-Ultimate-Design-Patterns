using System;
using System.Collections.Generic;

namespace DesignPatterns.Proxy.Exercise
{
    public class DbContext
    {
        private Dictionary<int, IProduct> _updatedObjects = new();
        
        public IProduct GetProduct(int id) {
            // Automatically generate SQL statements
            // to read the product with the given ID.
            Console.WriteLine($"SELECT * FROM products WHERE product_id = {id}");

            // Simulate reading a product object from a database.
            var product = new Product(id)
            {
                Name = "Product 1"
            };

            return new ProductProxy(product, this);
        }

        public void SaveChanges() {
            // Automatically generate SQL statements
            // to update the database.
            foreach (var (_, updatedObject) in _updatedObjects)
            {
                Console.WriteLine($"UPDATE products SET name = {updatedObject.Name} WHERE product_id = {updatedObject.Id}");
            }

            _updatedObjects.Clear();
        }

        public void MarkAsChanged(IProduct product) {
            _updatedObjects.Add(product.Id, product);
        }
    }
}