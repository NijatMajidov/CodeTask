using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    internal class Car
    {
		private static int _id;
		public  int Id { get; set; }
		public string Name { get; set; }
		public short Speed { get; set; }
		public string CarCode { get; set; }

        public Car(string name, short speed)
        {
            _id++;
            Id = _id;
            Name = name;
            Speed = speed;
            CarCode = GenerateCarCode(Name, Id);
        }

        static string GenerateCarCode(string name, int id)
        {
            string firstTwoChars = name.Substring(0, Math.Min(2, name.Length)).ToUpper();

            int carIndex = 1000 + id;
            return firstTwoChars + carIndex.ToString();
        }

        public void ShowCar()
        {
            Console.WriteLine($"{Id}, {Name}, {Speed}, {CarCode}");
        }
    }
}
