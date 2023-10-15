namespace Froggy
{
    public class Startup
    {
        static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Lake lake = new Lake(list);

            Console.Write(string.Join(", ", lake));
        }
    }
}
