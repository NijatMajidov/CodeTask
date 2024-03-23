namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee user = new Employee("Nicat", "Mecidov", 19, "BB207", 1024);
            Employee user1 = new Employee("Resid", "Babazade", 37, "BB207", 512);
            Employee user2 = new Employee("Asime", "Quliyeva", 24, "BB207", 256);


            Department department = new Department();
            department.AddEmployee(user);
            department.AddEmployee(user1);
            department.AddEmployee(user2);


            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~Xosh gelmisiniz!~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~Zehmet olmasa etmek istediyiniz emeliyati sechin~~~~~~~");
            Console.WriteLine("1. Employee elave et\n2. Butun ishchilere bax\n3. Maash aralıgına gore ishchileri axtarısh et\n0. Proqramı bitir");
            Console.WriteLine("--------------------------------------------------------------");

            byte secim;

            do
            {
                secim = Convert.ToByte(Console.ReadLine());
                switch (secim)
                {
                    case 0: Console.WriteLine("Proses bitdi\n Sagolun!"); break;

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
                        Console.WriteLine("Yeni işçi əlavə edildi.");
                        break;

                    case 2: department.ShowEmployeeInfo(); break;

                    case 3:
                        Console.WriteLine("Maaş aralığına göre axtarış etmek ucun min ve max deyer daxil edin");
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
