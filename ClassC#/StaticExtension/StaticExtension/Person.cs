using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtension
{
    internal class Person
    {
        private static int _id;
        public int Id { get; }
        public string FullName { get; set; }
        private sbyte _age;
        public sbyte Age { get { return _age; } set { if (value >= 0 && value <= 125) _age = value; } }

        public double Cash { get; set; }

        public Person(string fullname, sbyte age, double cash)
        {
            _id++;
            Id = _id;
            FullName = fullname;
            Age = age;
            Cash = cash;
        }
        public override string ToString()
        {
            return $"Id: {Id} FullNmae: {FullName} Age: {Age} Cash: {Cash}";
        }




    }
}
