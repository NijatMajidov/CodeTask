using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCar
{
    internal abstract class Vehicle
    {
        public string color {  get; set; }
        public int Year { get; set; }

        protected Vehicle(int year)
        {
            Year = year;
        }
        public abstract void Showinfo();

    }
}
