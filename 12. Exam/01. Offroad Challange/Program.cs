using System.Text;

Stack<int> fuelQuantity = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Queue<int> additionalConsumptionIndex = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Queue<int> comparisonElements = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
int counterAltitudeReached = 0;
int counterAltitued = fuelQuantity.Count;
List<string> altitudes = new();

while (fuelQuantity.Count > 0 && additionalConsumptionIndex.Count > 0)
{
    int currentFuel = fuelQuantity.Pop();
    int currentConsumption = additionalConsumptionIndex.Dequeue();
    int result = currentFuel - currentConsumption;
    int neededFuel = comparisonElements.Dequeue();

    if (result >= neededFuel)
    {
        counterAltitudeReached++;
        Console.WriteLine($"John has reached: Altitude {counterAltitudeReached}");
        altitudes.Add($"Altitude {counterAltitudeReached}");
    }
    else
    {
        counterAltitudeReached++;
        Console.WriteLine($"John did not reach: Altitude {counterAltitudeReached}");
        counterAltitudeReached--;
        break;
    }
}

if (counterAltitudeReached < 4 && counterAltitudeReached > 0)
{
    Console.WriteLine($"John failed to reach the top.");
    Console.Write("Reached altitudes: ");
    Console.WriteLine(string.Join(", ", altitudes));
}
else if (counterAltitudeReached == 0)
{
    Console.WriteLine("John failed to reach the top.");
    Console.WriteLine("John didn't reach any altitude.");
}
else if (fuelQuantity.Count == 0 && additionalConsumptionIndex.Count == 0 && comparisonElements.Count == 0)
{
    Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
}