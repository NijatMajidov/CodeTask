namespace CarClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gallery bos olmasin deye
            Car car1 = new Car("Mercedes", 200);
            Car car2 = new Car("Ferrari LaFerrari", 217);
            Car car3 = new Car("Bugatti Chiron Pur Sport", 218);
            Car car4 = new Car("Lamborghini Countach", 221);
            Car car5 = new Car("Bugatti Centodieci", 240);
            Car car6 = new Car("Tesla Roadster", 250);
            Car car7 = new Car("Bugatti Bolide", 311);

            Gallery SpeedCar = new Gallery("SpeedCar");

            SpeedCar.AddCar(car1);
            SpeedCar.AddCar(car2);
            SpeedCar.AddCar(car3);
            SpeedCar.AddCar(car4);
            SpeedCar.AddCar(car5);
            SpeedCar.AddCar(car6);
            SpeedCar.AddCar(car7);

            bool check = true;
            string choise;
            do
            {
                Console.WriteLine("\n Istediyiniz emeliyyati secin \n" +
                    "\n1 - Add Car" +
                    "\n2 - Show All Cars: Arraydeki butun Carlari gosterir" +
                    "\n3 - Find Car By Id: verilmis id-e uygun olan car'i tapib qaytarir" +
                    "\n4 - Find Car By CarCode: CarCode uygun olan car'i tapib qaytarir" +
                    "\n5 - Find Cars By Speed Interval: max ve min speed qebul edib bu suret araligindaki car'lari geri qaytarir" +
                    "\n0 - Programi bitir");

                choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        Console.WriteLine("Yeni masinin melumatlarini daxil edin");
                        Console.Write("Name: ");
                        string ad = Console.ReadLine();
                        short speed;
                        do
                        {
                            Console.Write("Speed: ");
                        } while (!short.TryParse(Console.ReadLine(), out speed) && speed > 0);

                        Car car = new Car(ad, speed);
                        SpeedCar.AddCar(car);
                        break;

                    case "2":
                        SpeedCar.ShowAllCars();
                        break;
                    case "3":
                        byte id;
                        do
                        {
                            Console.Write("Axtarilan Id: ");
                        } while (!byte.TryParse(Console.ReadLine(), out id) && id > 0);

                        SpeedCar.FindCarById(id).ShowCar();
                        break;
                    case "4":
                        string carCode = Console.ReadLine();
                        Console.WriteLine("Axtardiginiz carCode ni yazin: ");
                        SpeedCar.FindCarByCarCode(carCode).ShowCar();
                        break;
                    case "5":
                        int min, max;
                        do
                        {
                            Console.Write("Axtarilan min speed: ");
                        } while (!int.TryParse(Console.ReadLine(), out min) && min > 0);
                        do
                        {
                            Console.Write("Axtarilan max speed: ");
                        } while (!int.TryParse(Console.ReadLine(), out max) && max > 0);
                        
                        Car[] cars = SpeedCar.FindCarsBySpeedInterval(min, max);
                        for (int i = 0; i < cars.Length; i++)
                        {
                            cars[i].ShowCar();
                        }
                        break;
                    case "0":
                        check = false;
                        Console.WriteLine(" -------------------------------------------------------------\n|~~~~~~~~~~~~~~~~~~~~~~~~ Proses bitdi ~~~~~~~~~~~~~~~~~~~~~~~|");
                        Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~~~~~ Sagolun! ~~~~~~~~~~~~~~~~~~~~~~~~~|\n -------------------------------------------------------------");
                        break;

                    default:
                        Console.WriteLine("Bele bir secim yox idi axi!?");
                        break;

                }

            }while (check);


        }
    }
}
