using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Department
    {
        public Employee[] Employees = new Employee[0];

        #region AddEmployee
        public void AddEmployee(Employee user)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = user;
        }
        #endregion

        #region ShowEmployeeInfo
        public void ShowEmployeeInfo()
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine(Employees[i].GetEmployeeInfo());
            }
        }
        #endregion

        #region GetAllEmployees
        public Employee[] GetAllEmployees()
        {
            return Employees;
        }

        #endregion

        #region GetAllEmployeesBySalary
        public void GetAllEmployeesBySalary(int minSalary = 0, int maxSalary = int.MaxValue)
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].Salary >= minSalary && Employees[i].Salary <= maxSalary)
                    Console.WriteLine(Employees[i].GetEmployeeInfo());
            }

        }
        #endregion


    }
}
