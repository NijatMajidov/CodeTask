using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Employee
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

        #region ShowEmployeeInfo
        public void ShowEmployeeInfo()
        {
            Console.WriteLine(GetEmployeeInfo());
        }

        public string GetEmployeeInfo()
        {
            return $"{this.Name} {this.Surname}, |Age:{this.Age}|, Department name |{this.DepartmentName}|, |Salary:{this.Salary}|";
        }
        #endregion

    }
}
