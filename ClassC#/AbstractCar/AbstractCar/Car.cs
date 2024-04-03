﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCar
{
    internal class Car:Vehicle
    {
        public string Brand {  get; set; }
        public string Model { get; set; }

        public int MaxSpeed { get; set; }

        public Car(string brand, string model, int year):base(year)
        {
            Brand = brand;
            Model = model;
        }

        public override void Showinfo()
        {
            Console.WriteLine($"Car (Brand : {Brand} Model : {Model} Year : {Year})");
        }


    }
}
