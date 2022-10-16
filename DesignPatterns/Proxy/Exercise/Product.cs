using System;

namespace DesignPatterns.Proxy.Exercise
{
    public class Product : IProduct
    {
        public int Id { get; }
        public string Name { get; set; }

        public Product(int id) {
            Id = id;
        }
    }
}