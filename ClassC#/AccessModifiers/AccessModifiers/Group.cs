using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace AccessModifiers
{
    internal class Group
    {
        private string _no;
        public static string No { get; set; }

        public Student[] Students = new Student[0];

        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
            Console.WriteLine($"{student.FullName} ugurla {No}-a elave edildi");
        }

        private sbyte _studentLimit;
        public sbyte StudentLimit {
            get {  return _studentLimit; }
            set
            {
                if (value > 0 && value <= 20)
                    _studentLimit = value;
                else
                    _studentLimit = -1;
            }
        }
        
        public Group(string no, sbyte limit)
        {
            No = no;
            StudentLimit = limit;
            Console.WriteLine($"{No} yaradildi");
        }

        public void ShowGroup()
        {
            Console.WriteLine("\n Full Name      | GroupNo   | AvgPoint |");
            for (int i = 0; i < Students.Length; i++)
            {
                Students[i].ShowInfo();
            }
        }

        public void FilteredGroup(string searchWord) 
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].FullName == searchWord) 
                {
                    Students[i].ShowInfo();
                }      
            }
        }
    }
}