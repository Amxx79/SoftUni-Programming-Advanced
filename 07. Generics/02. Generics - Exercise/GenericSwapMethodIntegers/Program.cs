namespace GenericSwapMethodIntegers
{
    public class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> commands = new();
            for (int i = 0; i < n; i++)
            {
                int command = int.Parse(Console.ReadLine());
                commands.Add(command);
            }
            int[] indeces = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int indexOne = indeces[0];
            int indexTwo = indeces[1];

            Swap(commands, indexOne, indexTwo);
            foreach (var command in commands)
            {
                Console.WriteLine($"{command.GetType()}: {command}");
            }
        }

        static void Swap<T>(List<T> commands, int indexOne, int indexTwo)
        {
            T temp = commands[indexOne];
            commands[indexOne] = commands[indexTwo];
            commands[indexTwo] = temp;
        }
    }
}