string command = Console.ReadLine();

HashSet<string> partyPeople = new HashSet<string>();

while (command != "PARTY")
{
    partyPeople.Add(command);
    command = Console.ReadLine();
}

command = Console.ReadLine();
while (command != "END")
{
    if (partyPeople.Contains(command))
    {
        partyPeople.Remove(command);
    }
    command = Console.ReadLine();
}

Console.WriteLine(partyPeople.Count());

HashSet<string> vipGuest = new HashSet<string>();
foreach (string vip in partyPeople)
{
    char[] nameAsArray = vip.ToCharArray();

    if (nameAsArray[0] >= 48 && nameAsArray[0] <= 57)
    {
        vipGuest.Add(vip);
        partyPeople.Remove(vip);
    }
}


//печатане
foreach (string vip in vipGuest)
{
    Console.WriteLine(vip);
}

foreach (string people in partyPeople)
{
    Console.WriteLine(people);
}