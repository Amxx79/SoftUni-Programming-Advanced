int carsThrough = int.Parse(Console.ReadLine());

Queue<string> queue = new Queue<string>();

string input = Console.ReadLine();

int tracker = 0;

while (input != "end")
{
    if (input != "green")
    {
        queue.Enqueue(input);
    }

    else
    {
        for (int i = 1; i <= carsThrough; i++)
        {
            if (queue.Count > 0)
            {
                Console.WriteLine($"{queue.Dequeue()} passed!");
                tracker++;
            }
        }
    }
    input = Console.ReadLine();
}

Console.WriteLine($"{tracker} cars passed the crossroads.");