using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagment
{
    internal class Group
    {
        public string GroupNo { get ; set; }
        public int GroupLimit { get; set; }

        private Student[] students = new Student[0];

        public Group(string groupNo, int limit) 
        {
            GroupNo = groupNo;
            GroupLimit = limit;
        }
        public static bool CheckGroupNo(string groupNo)
        {
            bool checkUp = false;
            bool checkDigit = false;
            if(groupNo.Length == 5)
            {
                if (char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1])) checkUp = true;
                if (char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[3]))  checkDigit = true;
            }
            return checkUp && checkDigit;
        }
        
        public void AddStudent(Student student)
        {
            if (students.Length < GroupLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
            else Console.WriteLine("\nGrup doludur!\n");
        }

        public Student GetStudent (int id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Id == id) return students[i];
            }

            return null;
        }

        public Student[] GetAllStudents()
        {
            return students;
        }
    }
}
