using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Student
    {
        public string FullName { get; set; }
        public string GroupNo { get; set; } 
        public double AvgPoint { get; set; }

        public Student(string fullName)
        {
            FullName = fullName; 
        }

        public Student(string fullName, double point):this(fullName) 
        {
            AvgPoint = point;
            GroupNo = Group.No;
            Console.WriteLine("\nStudent yaradildi");
        }

        public void ShowInfo() 
        {
            Console.WriteLine($"{this.FullName}  | {this.GroupNo}     | {this.AvgPoint}");
        }
    }
}
