namespace SpeedRacing
{
    public class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split().ToArray();
                string model = carInfo[0];
                double fuelAmaount = double.Parse(carInfo[1]);
                double fuelConsmptForOneKm = double.Parse(carInfo[2]);

                Car car = new Car(model, fuelAmaount, fuelConsmptForOneKm);
                cars.Add(car.Model, car);
            }


            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] action = command.Split().ToArray();
                string carModel = action[1];
                double amountOfKm = double.Parse(action[2]);

                Car currentCar = cars[carModel];

                currentCar = currentCar.Drive(currentCar, amountOfKm);

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.Write($"{car.Key} {car.Value.FuelAmount:F2} {car.Value.TravelledDistance}");
                Console.WriteLine();
            }
        }
    }
}