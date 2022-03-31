namespace DesignPatterns.Iterator.Exercise
{
    public class Product
    {
        private readonly int _id;
        private readonly string _name;

        public Product(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public override string ToString()
        {
            return "Product{" +
                   "id=" + _id +
                   ", name='" + _name + '\'' +
                   '}';
        }
    }
}