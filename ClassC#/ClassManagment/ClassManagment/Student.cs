using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagment
{
    internal class Student
    {
        private static int _id;
        public int Id { get; set; }
        public string FullName { get; set; }
        public byte Point {  get; set; }

        public Student(string name, byte point)
        {
            _id++;
            Id = _id;
            FullName = name;
            Point = point;
        }
        public void StudentInfo() 
        {
            Console.WriteLine($"Id: {Id} | FullName: {FullName} | Point: {Point}");
        }

    }
}




