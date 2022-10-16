using System;

namespace DesignPatterns.Proxy.Exercise
{
    public class Product
    {
        public int Id { get; }
        public string Name { get; set; }

        public Product(int id) {
            Id = id;
        }
    }
}