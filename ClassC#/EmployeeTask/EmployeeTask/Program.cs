namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" -------------------------------------------------------------");
            Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~ Xos gelmisiniz! ~~~~~~~~~~~~~~~~~~~~~~|");
            Console.WriteLine("|~~~~~~ Zehmet olmasa etmek istediyiniz emeliyati secin ~~~~~~|");
            Console.WriteLine("|~~~~ 1. Isci elave et ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
            Console.WriteLine("|~~~~ 2. Butun iscilere bax ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
            Console.WriteLine("|~~~~ 3. Maas aralıgına gore iscileri axtarıs et ~~~~~~~~~~~~~|");
            Console.WriteLine("|~~~~ 0. Proqramı bitir! ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
            Console.WriteLine(" -------------------------------------------------------------");

            Department department = new Department();
            byte secim;

            do
            {
                secim = Convert.ToByte(Console.ReadLine());
                switch (secim)
                {
                    case 0:
                        Console.WriteLine(" -------------------------------------------------------------\n|~~~~~~~~~~~~~~~~~~~~~~~~ Proses bitdi ~~~~~~~~~~~~~~~~~~~~~~~|");
                        Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~~~~~ Sagolun! ~~~~~~~~~~~~~~~~~~~~~~~~~|\n -------------------------------------------------------------"); 
                        break;

                    case 1:
                        Console.WriteLine("Yeni işçinin məlumatlarını daxil edin:");
                        Console.Write("Ad: ");
                        string ad = Console.ReadLine();
                        Console.Write("Soyad: ");
                        string soyad = Console.ReadLine();
                        Console.Write("Yaş: ");
                        byte yas = Convert.ToByte(Console.ReadLine());
                        Console.Write("Departament adı: ");
                        string departamentAdi = Console.ReadLine();
                        Console.Write("Maaş: ");
                        double maas = Convert.ToDouble(Console.ReadLine());

                        Employee yeniIsci = new Employee(ad, soyad, yas, departamentAdi, maas);
                        department.AddEmployee(yeniIsci);
                        Console.WriteLine("Yeni isci elave edildi.");
                        break;

                    case 2: department.ShowEmployeeInfo(); break;

                    case 3:
                        Console.WriteLine("Maas aralıgına gore axtarıs etmek ucun min ve max deyer daxil edin");
                        int min, max;
                        min = Convert.ToInt32(Console.ReadLine()); max = Convert.ToInt32(Console.ReadLine());
                        department.GetAllEmployeesBySalary(min, max);
                        break;

                    default:
                        Console.WriteLine("Bele bir secim yox idi axi!?");
                        break;
                }
            } while (secim != 0);
        }
    }
}
