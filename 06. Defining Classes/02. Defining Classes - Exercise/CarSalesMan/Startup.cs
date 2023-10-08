namespace CarSalesMan
{
    public class Startup
    {
        static void Main()
        {
            Dictionary<string, Engine> engines = new();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //"{model} {power} {displacement} {efficiency}"
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command.Length == 2)
                {
                    string model = command[0];
                    int power = int.Parse(command[1]);

                    Engine engine = new(model, power);
                    engines.Add(model, engine);
                }
                else if (command.Length == 3)
                {
                    string model = command[0];
                    int power = int.Parse(command[1]);
                    int dicplacement;
                    bool isDicplacement = int.TryParse(command[2], out dicplacement);
                    if (isDicplacement)
                    {
                        Engine engine = new(model, power, dicplacement);
                        engines.Add(model, engine);
                    }
                    else
                    {
                        string efficiency = command[2];
                        Engine engine = new(model, power, efficiency);
                        engines.Add(model, engine);
                    }
                }
                else if (command.Length == 4)
                {
                    string model = command[0];
                    int power = int.Parse(command[1]);
                    int dicplacement = int.Parse(command[2]);
                    string efficiency = command[3];

                    Engine engine = new(model, power, dicplacement, efficiency);
                    engines.Add(model, engine);
                }
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                //"{model} {engine} {weight} {color}".
                string modelOfCar = command[0];
                string engine = command[1];
                Engine currentEngine = engines[engine];

                if (command.Length == 2)
                {
                    Car car = new(modelOfCar, currentEngine);
                    cars.Add(car);
                }
                if (command.Length == 3) 
                {
                    int weight;
                    bool isWeight = int.TryParse(command[2], out weight);
                    if (isWeight)
                    {
                        Car car = new(modelOfCar, currentEngine, weight);
                        cars.Add(car);
                    }
                    else
                    {
                        string color = command[2];
                        Car car = new(modelOfCar, currentEngine, color);
                        cars.Add(car);

                    }
                }
                if (command.Length == 4)
                {
                    int weight = int.Parse(command[2]);
                    string color = command[3];
                    Car car = new(modelOfCar, currentEngine, weight, color);
                    cars.Add(car);
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");

                if (car.Engine.Displacement != 0)
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");//this
                }
                else if (car.Engine.Displacement == 0)
                {
                    Console.WriteLine($"    Displacement: n/a");
                }


                if (car.Engine.Efficiency != null)
                {
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");//this
                }
                else if (car.Engine.Efficiency == null)
                {
                    Console.WriteLine($"    Efficiency: n/a");//this

                }

                if (car.Weight != 0)
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                else if (car.Weight == 0)
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                if (car.Color != null)
                {
                    Console.WriteLine($"  Color: {car.Color}");
                }
                else if (car.Color == null)
                {
                    Console.WriteLine($"  Color: n/a");
                }
            }

        }
    }
}