using System.Collections.Generic;
using DesignPatterns.FactoryMethod.Sharp;

namespace DesignPatterns.FactoryMethod
{
    public class ProductController : SharpController
    {
        public void ListProducts()
        {
            // Get products from a database
            var context = new Dictionary<string, object>();
            // context.put(products)
            Render("products.html", context);
        }
    }
}