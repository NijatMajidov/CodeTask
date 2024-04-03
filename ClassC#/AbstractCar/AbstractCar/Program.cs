namespace AbstractCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[3];

            Car car = new Car("BMW", "F10", 2010);
            Car car1 = new Car("Mercedes", "Sedans", 2018);
            Bus bus = new Bus(60, 2008);

            vehicles[0] = car;
            vehicles[1] = bus;
            vehicles[2] = car1;

            foreach(var item in vehicles) item.Showinfo();
        }

       
    }
}
