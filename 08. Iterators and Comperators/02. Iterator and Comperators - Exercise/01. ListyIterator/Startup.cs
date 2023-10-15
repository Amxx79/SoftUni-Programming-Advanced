namespace ListyIterator
{
    public class Startup
    {
        static void Main()
        {
            List<string> list = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToList();
            ListyIterator<string> listy = new(list);

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(listy.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listy.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            listy.Print();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }

            }
        }
    }
}