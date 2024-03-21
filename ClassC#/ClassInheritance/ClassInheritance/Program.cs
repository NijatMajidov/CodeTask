namespace ClassInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

        }

    }

    class Employee
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string DepartmentName;
        public double Salary;

        public Employee(string name, string surname, byte age, string departmentName, double salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentName = departmentName;
            Salary = salary;
        }
    }

    class Department
    {
        Employee[] employees = { };
        public AddEmploye()
        {

        }
    }

}
