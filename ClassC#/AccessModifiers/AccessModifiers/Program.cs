using System;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yeni grup yaratmaq ucun melumatlari daxil edin!");

            string no;
            do
            {
                Console.WriteLine("\nGrup No: (2 boyuk herf ve 3 reqem daxil edin)");
                no = Console.ReadLine();

            } while (!ValidGroupNo(no));

            sbyte limit;
            do
            {
                Console.WriteLine("\nGrupun telebe limit sayini daxil edin ( 0 - 20 )");
            } while (!(sbyte.TryParse(Console.ReadLine(), out limit) && (limit >= 0 && limit<21)));

            Group group = new Group(no,limit);

            string choice;
            bool check= true;
            do
            {
                Console.WriteLine("\n|~~~~~~~~~~~~~~~~~~~~~~ Xos gelmisiniz! ~~~~~~~~~~~~~~~~~~~~~~|" +
                    "\n|~~~~~~ Zehmet olmasa etmek istediyiniz emeliyati secin ~~~~~~|\n " +
                    "\n    1. Telebe elave et" +
                    "\n    2. Bütün telebelere bax" +
                    "\n    3. Telebeler üzre axtarış et" +
                    "\n    0. Proqramı bitir\n"+
                    "\n|-------------------------------------------------------------|\n");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (group.Students.Length != limit)
                        { 
                            Console.WriteLine("Yeni telebe yaratmaq ucun melumatlarini daxil edin:");

                            string fullName = Console.ReadLine();

                            double avgPoint;
                            do
                            {
                                Console.WriteLine("Telebenin ortalamasi: ");
                            } while (!(double.TryParse(Console.ReadLine(), out avgPoint) && (avgPoint >= 0 && avgPoint <= 100)));

                            Student student = new Student(fullName, avgPoint);
                            group.AddStudent(student);
                        }
                        else Console.WriteLine("\n Grup doludur!\n");
                        break;

                    case "2":
                        group.ShowGroup();
                        break; 
                    case "3":
                        Console.WriteLine("Axtarilan adi daxil edin: ");
                        string search = Console.ReadLine();
                        group.FilteredGroup(search); break;

                    case "0":
                        check = false;
                        Console.WriteLine(" -------------------------------------------------------------" +
                                "\n|~~~~~~~~~~~~~~~~~~~~~~~~ Proses bitdi ~~~~~~~~~~~~~~~~~~~~~~~|" +
                                "\n|~~~~~~~~~~~~~~~~~~~~~~~~~~ Sagolun! ~~~~~~~~~~~~~~~~~~~~~~~~~|" +
                                "\n -------------------------------------------------------------");
                        break;

                    default:
                        Console.WriteLine("\n     BELE BIR SECIM YOXDUR!?\n Secimleri unutmusansa yeniden bax\n");
                        break;
                }
            }while (check);
        }

        static bool ValidGroupNo(string groupNo) 
        {
            bool check = true;
            if (groupNo == null) return false;
            
            if (groupNo.Length != 5) return false;

            if (groupNo[0] == ' ' || groupNo[1] == ' ' || groupNo[2] == ' ' || groupNo[3] == ' ' || groupNo[4] == ' ') return false;

            if (!char.IsUpper(groupNo[0]) || !char.IsUpper(groupNo[1])) return false;

            for (int i = 2; i < 5; i++)
            {
                if (!byte.TryParse(groupNo.Substring(2),out byte a)) return false;
            }

            return check;
        }
    }
}
