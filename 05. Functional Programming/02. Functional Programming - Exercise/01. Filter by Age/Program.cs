using System;

int rows = int.Parse(Console.ReadLine());
List<Person> people = new List<Person>();

for (int i = 0; i < rows; i++)
{
    List<string> information = Console.ReadLine()
        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
        .ToList();

    string name = information[0];
    int age = int.Parse(information[1]);

    Person person = new Person();
    person.Name = name;
    person.Age = age;
    peoples.Add(person.Name, person);


    people.Add(person);
    string user = person.Name;

}

string oldOrYong = Console.ReadLine();
int years = int.Parse(Console.ReadLine());

if (oldOrYong == "younger")
{
    people = people.Where(x => x.Age < years).ToList();
}
else if (oldOrYong == "older")
{
    people = people.Where(x => x.Age >= years).ToList();

}

string[] printData = Console.ReadLine().Split();

if (printData[0] == "name" && printData.Length == 1)
{
    foreach (var person in people)
    {
        Console.WriteLine($"{person.Name}");
    }
}
else if (printData[0] == "age" && printData.Length == 1)
{
    foreach (var person in people)
    {
        Console.WriteLine($"{person.Age}");
    }
}

else if (printData[0] == "name" && printData[1] == "age")
{
    //Lucas - 20
    //Mia - 29
    //Noah - 31

    foreach (var person in people)
    {
        Console.WriteLine($"{person.Name} - {person.Age}");
    }
}
var current = int.Parse(Console.ReadLine());


class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}