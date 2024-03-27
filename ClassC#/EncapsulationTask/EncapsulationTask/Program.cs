namespace EncapsulationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // library bos olmasin deye 2 kitab elave etmisem
            // /*
            Product first = new Product(1, 15.5, "Birinci", 4);
            Product second = new Product(2, 9.99, "Ikinci ", 10);

            Book firstBook = new Book(first.No, first.Price, first.Name, first.Count, "Nagil" );
            Book secondBook = new Book(second.No, second.Price, second.Name, second.Count, "Dram " );

            Library library = new Library();
            library.AddBook(firstBook);
            library.AddBook(secondBook);
            // */

            Console.WriteLine(" -------------------------------------------------------------" +
            "\n|~~~~~~~~~~~~~~~~~~~~~~ Xos gelmisiniz! ~~~~~~~~~~~~~~~~~~~~~~|" +
            "\n|~~~~~~ Zehmet olmasa etmek istediyiniz emeliyati secin ~~~~~~|" +
            "\n|~~~~ 1. Kitab elave et ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|" +
            "\n|~~~~ 2. Kitablari janra uygun filtir et ~~~~~~~~~~~~~~~~~~~~~|" +
            "\n|~~~~ 3. Kitablari qiymete uygun filtir et ~~~~~~~~~~~~~~~~~~~|" +
            "\n|~~~~ 4. Butun kitablari goster ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|" +
            "\n|~~~~ 0. Proqramı bitir! ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|" +
            "\n -------------------------------------------------------------");

            bool cheak = true;
            string secim;
            do
            {
                secim = Console.ReadLine();

                switch (secim)
                {
                    
                    case "1":
                        Console.WriteLine("Yeni kitab elave etmek ucun product melumatlarini daxil edin:");
                        byte no;
                        do
                        {
                            Console.WriteLine("Product No: ");
                        } while (!byte.TryParse(Console.ReadLine(), out no)&& no >= 0);

                        double price;
                        do
                        {
                            Console.WriteLine("Product Price: ");
                        } while (!double.TryParse(Console.ReadLine(), out price) && price>=0);

                        Console.WriteLine("Product Name: ");
                        string name= Console.ReadLine();

                        byte count;
                        do
                        {
                            Console.WriteLine("Product Count: ");
                        } while (!byte.TryParse(Console.ReadLine(), out count) && count >= 0);

                        Console.WriteLine("Kitabin janrini daxil edin ");
                        string genre= Console.ReadLine();

                        Product newPrdct = new Product(no, price, name, count);
                        Book newBook = new Book(no, price, name, count, genre);
                        library.AddBook(newBook);
                        Console.WriteLine("Kitab ugurla elave edildi! ");
                        break;

                    case "2":
                        Console.WriteLine("Kitablari janra uygun filtir etmek ucun janr daxil edin");
                        string janr = Console.ReadLine();

                        Book[] filbooks =library.GetFilteredBooks(janr);

                        for (int i = 0; i < filbooks.Length; i++)
                        {
                            filbooks[i].ShowInfo();
                        }
                        if (filbooks.Length == 0)  Console.WriteLine("Bu janrda kitab tapilmadi!"); 
                        break;

                    case "3":
                        Console.WriteLine("Kitablari qiymete uygun filtir etmek ucun min ve max qiymet daxil edin");

                        int minPrice;
                        do
                        {
                            Console.WriteLine("Min Price: ");
                        } while (!int.TryParse(Console.ReadLine(), out minPrice) && minPrice >= 0);

                        int maxPrice;
                        do
                        {
                            Console.WriteLine("Max Price: ");
                        } while (!int.TryParse(Console.ReadLine(), out maxPrice) && maxPrice >= 0);

                        Book[] filbooks2 = library.GetFilteredBooks(minPrice,maxPrice);

                        for (int i = 0; i < filbooks2.Length; i++)
                        {
                            filbooks2[i].ShowInfo();
                        }
                        if (filbooks2.Length==0)  Console.WriteLine("Bu qiymet araliginda kitab tapilmadi!"); 
                    break;

                    case "4": library.ShowAllBooks(); break;

                    case "0":
                        cheak = false;
                        Console.WriteLine(" -------------------------------------------------------------" +
                            "\n|~~~~~~~~~~~~~~~~~~~~~~~~ Proses bitdi ~~~~~~~~~~~~~~~~~~~~~~~|"+
                        "\n|~~~~~~~~~~~~~~~~~~~~~~~~~~ Sagolun! ~~~~~~~~~~~~~~~~~~~~~~~~~|" +
                            "\n -------------------------------------------------------------");
                    break;

                    default:
                        Console.WriteLine("     BELE BIR SECIM YOXDUR!?\n Secimleri unutmusansa yeniden bax"+
                            "\n -------------------------------------------------------------"+
                            "\n|~~~~ 1. Kitab elave et ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|" +
                            "\n|~~~~ 2. Kitablari janra uygun filtir et ~~~~~~~~~~~~~~~~~~~~~|" +
                            "\n|~~~~ 3. Kitablari qiymete uygun filtir et ~~~~~~~~~~~~~~~~~~~|" +
                            "\n|~~~~ 4. Butun kitablari goster ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|" +
                            "\n|~~~~ 0. Proqramı bitir! ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|" +
                            "\n -------------------------------------------------------------");
                    break;
                }
            } while (cheak);
        }
    }
}

