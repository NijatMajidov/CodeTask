using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtension
{
    internal class Store
    {
        private static int _id;
        public int Id { get; set; }

        Product[] products = new Product[0];

        public Store()
        {
            _id++;
            Id = _id;
        }
        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }

        public void RemoveProductByNo(int no)
        {
            int temp = -1;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].No == no)
                {
                    temp = i;
                    break;
                }
            }

            if (temp != -1)
            {
                for (int i = temp; i < products.Length - 1; i++)
                {
                    products[i] = products[i + 1];
                }
                Array.Resize(ref products, products.Length - 1);
                Console.WriteLine("Mehsul ugurla silindi.");
            }
            else Console.WriteLine("Axtarilan No yoxdur!");
        }

        public Product GetProduct(int no)
        {
            foreach (Product product in products)
            {
                if (product.No == no)
                    return product;
            }
            return null;
        }

        public Product[] FilterProductsByType(string type)
        {
            Product[] filProducts = new Product[0];
            foreach (Product product in products)
            {
                if (product.Type == type)
                {
                    Array.Resize(ref filProducts, filProducts.Length + 1);
                    filProducts[filProducts.Length - 1] = product;
                }

            }
            return filProducts;
        }

        public Product[] FilterProductsByName(string name)
        {
            Product[] filProducts = new Product[0];
            foreach (Product product in products)
            {
                if (product.Name == name)
                {
                    Array.Resize(ref filProducts, filProducts.Length + 1);
                    filProducts[filProducts.Length - 1] = product;
                }

            }
            return filProducts;
        }

        public void Sale(int no, Person person)
        {
            Product product = GetProduct(no);
            if (product != null && product.Count > 0 && person.Cash >= product.Price)
            {
                product.Count--;
                person.Cash -= product.Price;
            }
            else
            {
                Console.WriteLine("Satış uğursuz oldu. Mehsul yoxdur və ya balansinizda kifayet qeder pul yoxdur.");
            }
        }
    }
}
