namespace StaticExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Product product = new Product("alma", 20, "meyve", 5);
            Product product2 = new Product("armud", 10, "meyve", 5);

            store.AddProduct(product);
            store.AddProduct(product2);

            string choice;
            bool check = true;
            do
            {
                Console.WriteLine("1. Mehsul elave et" +
                    "\n2. Mehsul sil" +
                    "\n3. Mehsula bax" +
                    "\n4. Type'a gore mehsullara bax" +
                    "\n5. Ada gore mehsullara bax" +
                    "\n0. Proqramdan cix\n");

                Console.Write("Emeliyyat nomresini secin: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Product newproduct = CreateProduct();
                        store.AddProduct(newproduct);
                        Console.WriteLine("Mehsul ugurla elave edildi.");
                        break;
                    case "2":
                        int no;
                        do
                        {
                            Console.Write("Silmek istediyiniz mehsulun No-sunu daxil edin: ");
                        }while (!int.TryParse(Console.ReadLine(), out no));
                        
                        store.RemoveProductByNo(no);
                        break;
                    case "3":
                        ViewProduct(store);
                        break;
                    case "4":
                        Console.Write("Baxmaq istediyiniz mehsullarin Type-ni daxil edin: ");
                        string type = Console.ReadLine();

                        Product[] products = store.FilterProductsByType(type);
                        if (products.Length > 0)
                        {
                            foreach (Product item in products)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Bu tipde mehsul tapilmadi.");
                        }
                        break;
                    case "5":
                        Console.Write("Baxmaq istediyiniz mehsullarin adini daxil edin: ");
                        string name = Console.ReadLine();

                        Product[] filProducts = store.FilterProductsByName(name);
                        if (filProducts.Length > 0)
                        {
                            foreach (Product item in filProducts)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Bu ada uygun mehsul tapilmadi.");
                        }
                        break;
                    case "0":
                        Console.WriteLine("EXIT");
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Zehmet olmasa duzgun emeliyyat nomresi secin!");
                        break;
                }
            } while (check);
        }
        static Product CreateProduct()
        {
            Console.Write("Mehsulun adini daxil edin: ");
            string name = Console.ReadLine();

            double price;
            do
            {
                Console.Write("Mehsulun qiymetini daxil edin: ");
            } while (!double.TryParse(Console.ReadLine(), out price) || price < 0);

            Console.Write("Mehsulun tipini daxil edin: ");
            string type = Console.ReadLine();

            int count;
            do
            {
                Console.Write("Mehsulun sayini daxil edin: ");
            }while (!int.TryParse(Console.ReadLine(), out count) || count < 0);

            Product newproduct = new Product(name, price, type, count);
            return newproduct;
        }

        static void ViewProduct(Store store)
        {
            int no;
            do
            {
                Console.Write("Baxmaq istediyiniz mehsulun No-sunu daxil edin: ");
            } while (!int.TryParse(Console.ReadLine(), out no));

            Product product = store.GetProduct(no);
            if (product != null)
            {
                Console.WriteLine(product);
            }
            else
            {
                Console.WriteLine("Mehsul tapilmadi.");
            }
        }

    }
}
