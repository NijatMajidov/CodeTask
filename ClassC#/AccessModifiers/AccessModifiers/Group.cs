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
        public string No { get; set; }

        public Student[] Students = new Student[0];

        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
            Console.WriteLine("student ugurla elave edildi");
        }

        private byte _studentLimit;
        public byte StudentLimit {
            get {  return _studentLimit; }
            set
            {
                 if (value > 0 && value <= 20)
                     _studentLimit = value;
                 else
                     Console.WriteLine("Araliga uygun limit daxil edin");
                
            }
        }
        public Group(string no)
        {
            No = no;
        }
        public Group(string no, byte limit) : this(no)
        {
            StudentLimit = limit;
            Console.WriteLine("Grup yarandi");
        }

        public void ShowGroup()
        {
            Console.WriteLine("Full Name      | GroupNo   | AvgPoint |");
            for (int i = 0; i < Students.Length; i++)
            {
                Students[i].ShowInfo();
            }
        }
    }
}
