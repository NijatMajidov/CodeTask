using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCar
{
    internal class Bus:Vehicle
    {
        private byte _passengerCount;
        public byte PassengerCount { get { return _passengerCount; } set { if (value > 0) _passengerCount = value; } }

        public Bus(byte passCount, int year):base(year)
        {
            PassengerCount = passCount;
        }
        public override void Showinfo()
        {
            Console.WriteLine($"Bus (Passenger count : {PassengerCount} Year : {Year})");
        }
    }
}
