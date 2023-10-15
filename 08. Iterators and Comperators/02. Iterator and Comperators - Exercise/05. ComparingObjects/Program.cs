using System.Diagnostics.Metrics;

namespace ComparingObjects
{
    public class Startup
    {
        static void Main()
        {
            string command;
            List<Person> people = new List<Person>();

            while ((command = Console.ReadLine()) != "END")
            {
                string[] personTokens = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = personTokens[0];
                int age = int.Parse(personTokens[1]);
                string town = personTokens[2];

                Person person = new(name, age, town);
                people.Add(person);

            }

            int result = 0;
            int matches = 0;
            int notMatches = 0;

            int indexToCompare = int.Parse(Console.ReadLine()) - 1;
            Person personToCompare = people[indexToCompare];
            foreach (Person person in people)
            {
                
                result = personToCompare.CompareTo(person);
                if (result == 0)
                {
                    matches++;
                }
                else
                {
                    notMatches++;
                }
            }

            if (matches == 1)
            {
                Console.WriteLine("No matches");
                Environment.Exit(0);
            }
            Console.WriteLine("{0} {1} {2}", matches, notMatches, people.Count);
        }
    }
}