using System.Collections.Generic;
using DesignPatterns.FactoryMethod.Match;

namespace DesignPatterns.FactoryMethod
{
    public class ProductController : Controller
    {
        public void ListProducts()
        {
            // Get products from a database
            var context = new Dictionary<string, object>();
            // context.put(products)
            Render("products.html", context, new MatchViewEngine());
        }
        
    }
}