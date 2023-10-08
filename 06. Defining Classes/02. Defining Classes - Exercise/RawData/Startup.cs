using System.Data;

namespace RawData
{
    public class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new();
            for (int i = 0; i < n; i++)
            {
                List<string> carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                double tire1Pressure = double.Parse(carInfo[5]);
                int tire1Age= int.Parse(carInfo[6]);
                double tire2Pressure = double.Parse(carInfo[7]);
                int tire2Age = int.Parse(carInfo[8]);
                double tire3Pressure = double.Parse(carInfo[9]);
                int tire3Age = int.Parse(carInfo[10]);
                double tire4Pressure = double.Parse(carInfo[11]);
                int tire4Age = int.Parse(carInfo[12]);

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tire1Pressure, tire1Age, tire2Pressure, tire2Age,
                   tire3Pressure, tire3Age, tire4Pressure, tire4Age);

                cars.Add(car);
            }

            string command = Console.ReadLine();
            string[] filteredCarsFragile = cars.Where(c => c.Cargo.CargoType == "fragile" 
                 && c.Tyres.Any(t => t.Pressure < 1))
                .Select(c => c.Model).ToArray();

            string[] filteredCarsFlammable = cars.Where(c => c.Cargo.CargoType == "flammable" 
            && c.Engine.EnginePower > 250).Select(c => c.Model).ToArray();

            if (command == "fragile")
            {
                Console.WriteLine(string.Join(Environment.NewLine , filteredCarsFragile));
            }

            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, filteredCarsFlammable));
            }
        }
    }
}