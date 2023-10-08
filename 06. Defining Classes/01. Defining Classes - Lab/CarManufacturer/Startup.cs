using System.Net;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            string tire = Console.ReadLine();
            List<Tire[]> tires = new List<Tire[]>();

            while (tire != "No more tires")
            {
                string[] tireInfo = tire.Split().ToArray(); //COMMANDS
                List<Tire> tireList = new();

                for (int i = 0; i < tireInfo.Length; i++)
                {
                    int year = int.Parse(tireInfo[i]);
                    double pressure = double.Parse(tireInfo[i + 1]);
                    Tire newTire = new Tire(year, pressure);
                    tireList.Add(newTire);
                    i += 1;
                }
                tires.Add(tireList.ToArray());

                tire = Console.ReadLine();
            }

            string engineCommand = Console.ReadLine();

            List<Engine> engines = new();
            while (engineCommand != "Engines done")
            {
                string[] commandArray = engineCommand.Split().ToArray();
                int horsePower = int.Parse(commandArray[0]);
                double cubicCapacity = double.Parse(commandArray[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);

                engineCommand = Console.ReadLine();
            }

            string carData = Console.ReadLine();
            List<Car> cars = new();

            while (carData != "Show special")
            {
                List<string> carDataList = carData.Split().ToList();

                string make = carDataList[0];
                string model = carDataList[1];
                int year = int.Parse(carDataList[2]);
                int fuelQuantity = int.Parse(carDataList[3]);
                int fuelConsumption = int.Parse(carDataList[4]);
                int enginesIndex = int.Parse(carDataList[5]);
                int tiresIndex = int.Parse(carDataList[6]);

                Car newCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[enginesIndex], tires[tiresIndex]);

                cars.Add(newCar);

                carData = Console.ReadLine();
            }

            Func<Car, bool> filter = c => c.Year >= 2017 
            && c.Engine.HorsePower > 330 
            && c.Tires.Sum(t => t.Pressure) >= 9 && c.Tires.Sum(t => t.Pressure) <= 10;

            List<Car> specialCars = new();
            foreach (var car in cars.Where(filter))
            {
                car.Drive(20);
                specialCars.Add(car);
            }

            foreach (var car in specialCars)
            {
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}
