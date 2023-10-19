Queue<int> timeForDevPerTask = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Stack<int> numberOfTaskPerDev = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

//GAMES
int darthVaredDuckyCount = 0;
int thorDuckyCount = 0;
int bigBlueRubberCount = 0;
int smallYeallowCount = 0;

while (timeForDevPerTask.Count > 0 && numberOfTaskPerDev.Count > 0)
{
    int timeForCurrentTask = timeForDevPerTask.Dequeue();
    int numberOfTasks = numberOfTaskPerDev.Pop();

    int resultOnTime = timeForCurrentTask * numberOfTasks;

    if (resultOnTime >= 0 && resultOnTime <= 240)
    {
        if (resultOnTime >= 0 && resultOnTime <= 60)
        {
            darthVaredDuckyCount++;
        }
        else if (resultOnTime >= 61 && resultOnTime <= 120)
        {
            thorDuckyCount++;
        }
        else if (resultOnTime >= 121 && resultOnTime <= 180)
        {
            bigBlueRubberCount++;
        }
        else if (resultOnTime >= 181 && resultOnTime <= 240)
        {
            smallYeallowCount++;
        }
    }
    else if (resultOnTime > 240)
    {
        numberOfTasks -= 2;
        numberOfTaskPerDev.Push(numberOfTasks);
        timeForDevPerTask.Enqueue(timeForCurrentTask);
    }
}

Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");
Console.WriteLine($"Darth Vader Ducky: {darthVaredDuckyCount}");
Console.WriteLine($"Thor Ducky: {thorDuckyCount}");
Console.WriteLine($"Big Blue Rubber Ducky: {bigBlueRubberCount}");
Console.WriteLine($"Small Yellow Rubber Ducky: {smallYeallowCount}");
