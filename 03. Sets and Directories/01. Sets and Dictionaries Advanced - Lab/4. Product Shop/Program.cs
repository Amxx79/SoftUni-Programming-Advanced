string[] productInfo = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
string command = productInfo[0];

Dictionary<string,Dictionary<string,double>> markets = new Dictionary<string,Dictionary<string,double>>();


while (command != "Revision")
{
    string product = productInfo[1];
    double price = double.Parse(productInfo[2]);
    if (!markets.ContainsKey(command))
    {
        markets.Add(command, new Dictionary<string, double>());
    }
    markets[command].Add(product, price);

    productInfo = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
    command = productInfo[0];
}


foreach (var kvp in markets.OrderBy(x=>x.Key))
{
    Console.WriteLine($"{kvp.Key}->");
    foreach (var kvp2 in kvp.Value)
    {
        Console.WriteLine($"Product: {kvp2.Key}, Price: {kvp2.Value}");
    }
}