namespace Stack
{
    public class Startup
    {
        static void Main()
        {
            string command;
            CustomStack<int> stack = new CustomStack<int>();

            while ((command = Console.ReadLine()) != "END")
            {
                List<string> tokens = new List<string>
                    (command.Split(new char[] {',', ' '}
                    , StringSplitOptions.RemoveEmptyEntries)
                    .ToList());
                string action = tokens[0];

                if (action == "Push")
                {
                    int[] itemsToPush = tokens.Skip(1).Select(int.Parse).ToArray();
                    foreach (var item in itemsToPush)
                    {
                        stack.Push(item);
                    }
                }

                else if (command == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
            }

            for (int i = 1; i < 3; i++)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}