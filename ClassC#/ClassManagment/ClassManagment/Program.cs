namespace ClassManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            string choise;
            Console.WriteLine("Yeni user yaradmaq ucun melumatlari daxil edin\n");

            Console.WriteLine("Ad: ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();
            
            do { 
                    Console.WriteLine("\n1. Show info\r\n" +
                        "2. Create new group\n");

                choise = Console.ReadLine();
                
                

                switch (choise)
                    {
                        
                        case "1":
                        Console.WriteLine($"User {fullName}");
                        break;


                        case "2":

                        Console.WriteLine("Yeni grup yaradmaq ucun melumatlari daxil edin\n");
                        string groupNo;
                        bool groupCheck = true;
                        do
                        {
                            Console.WriteLine("Group No: ");
                            groupNo = Console.ReadLine();

                        } while (!Group.CheckGroupNo(groupNo));

                        int limit;
                        do
                        {
                            Console.WriteLine("Grup limiti: ");
                        } while (!(int.TryParse(Console.ReadLine(), out limit)&&(limit>=5 && limit <=18)));

                        Group newGroup = new Group(groupNo, limit);
                        
                        bool checkmenu = true;
                        do
                        {
                            Console.WriteLine("\n1. Show all students\r\n" +
                                "2. Get student by id\r\n" +
                                "3. Add student\r\n" +
                                "0. Quit\n");

                            choise = Console.ReadLine();

                            
                            switch(choise)
                            {
                                case "1":
                                    Student[] AllStudents= newGroup.GetAllStudents();
                                    for(int i = 0; i < AllStudents.Length; i++)
                                    {
                                        AllStudents[i].StudentInfo();
                                    }
                                    break;
                                case "2":
                                    int id;
                                    do
                                    {
                                        Console.WriteLine("Axtarilan id: ");
                                    } while (!int.TryParse(Console.ReadLine(), out id));

                                    newGroup.GetStudent(id).StudentInfo();
                                    break; 
                                case "3":
                                    Console.WriteLine("Yeni student yaradmaq ucun melumatlari daxil edin\n");
                                    Console.WriteLine("Ad: ");
                                    string name = Console.ReadLine();
                                    byte points;
                                    do
                                    {
                                        Console.WriteLine("Point: ");
                                    } while (!byte.TryParse(Console.ReadLine(), out points));

                                    Student newstudent = new Student(name, points);
                                    newGroup.AddStudent(newstudent);
                                    break;

                                case "0":
                                    checkmenu = false;
                                    Console.WriteLine("Esas menu ya qayitdi");
                                    break;
                            }
                        } while (checkmenu);
                        break;
                    }
            } while (check);
        }
    }
}
