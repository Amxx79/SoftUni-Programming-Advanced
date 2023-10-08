using System;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Family family = new();
            int n = int.Parse(Console.ReadLine());
            //List<string> lines = new();
            SortedDictionary<string, int> lines = new();

            for (int i = 0; i < n; i++)
            {
                string[] personData = Console.ReadLine().Split().ToArray();
                string name = personData[0];
                int age = int.Parse(personData[1]);

                Person person = new Person(name, age);
                family.AddMember(person);

                bool isOlder = person.GetAllPeopleAbove30(person);
                if (isOlder)
                {
                    //lines.Add($"{person.Name} - {person.Age}");
                    lines.Add(person.Name, person.Age);
                }
            }

            foreach (var kvp in lines)
            {
                Console.Write($"{kvp.Key} - {kvp.Value}");
                Console.WriteLine();
            }
            
            
        }
    }
}

