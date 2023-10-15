using Equality_Logic;

namespace EqualityLogic
{
    public class Startup
    {
        static void Main()
        {
            HashSet<Person> people = new HashSet<Person>();
            SortedSet<Person> sortedPeople = new SortedSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] personProps = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = personProps[0];
                int age = int.Parse(personProps[1]);

                Person person = new()
                {
                    Name = name,
                    Age = age,
                };

                people.Add(person);
                sortedPeople.Add(person);
            }

            Console.WriteLine(people.Count);
            Console.WriteLine(sortedPeople.Count);
        }
    }
}