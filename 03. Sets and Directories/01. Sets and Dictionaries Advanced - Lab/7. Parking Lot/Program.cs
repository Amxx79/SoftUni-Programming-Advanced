string command = Console.ReadLine();

HashSet<string> numbers = new HashSet<string>();
while (command != "END")
{
    string action = command.Split(", ")[0];
    string licensePlate = command.Split(", ")[1];
    if (action == "IN")
    {
        numbers.Add(licensePlate);
    }
    else if (action == "OUT")
    {
        numbers.Remove(licensePlate);
    }


    command = Console.ReadLine();
}

if (numbers.Count == 0)
{
    Console.WriteLine("Parking Lot is Empty");
}
else
{
    foreach (string car in numbers)
    {
        Console.WriteLine(car);
    }
}