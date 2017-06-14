using System;
using System.Linq;
using System.Threading.Tasks;

namespace refractor3_demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var store = new Store();
            store.AddProduct(new Product("Pizza", 10.00, 1.00, 52));
            store.AddProduct(new Product("Pizza", 10.00, 1.00, 26));
            store.AddProduct(new Product("Pizza", 10.00, 1.00, 10));
            store.GetCostOfProducts();
        }
    }
}
