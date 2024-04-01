using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    internal class Gallery
    {
        private static int _id;
        public static int Id { get; set; }
        public string Name { get; set; }
        public Gallery(string name)
        {
            _id++;
            Id = _id;
            Name = name;
        }

        Car[] Cars = new Car[0];

        public void AddCar(Car car)
        {
            Array.Resize(ref Cars, Cars.Length+1);
            Cars[Cars.Length-1]= car;

            Console.WriteLine($"{this.Name} Galleriyasina {car.Name} elave edildi!\n");
        }

        public void ShowAllCars()
        {
            Console.WriteLine("| Id | Name | Speed | CarCode |");
            for (int i = 0; i < Cars.Length; i++)
            {
                Cars[i].ShowCar();
            }
        }

        public Car[] GetAllCars()
        {
            return Cars;
        }

        public Car FindCarById(int id)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].Id == id)
                {
                   return Cars[i];
                }
            }
            return null;
        }

        public Car FindCarByCarCode(string carCode) 
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].CarCode == carCode)
                {
                    return Cars[i];
                }
            }
            return null;
        }

        public Car[] FindCarsBySpeedInterval(int min, int max)
        {
            Car[] findCars = new Car[0];

            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].Speed >= min && Cars[i].Speed <= max)
                {
                    Array.Resize(ref findCars, findCars.Length + 1);
                    findCars[findCars.Length - 1] = Cars[i];
                }
            }

            return findCars;
        }
    }
}
