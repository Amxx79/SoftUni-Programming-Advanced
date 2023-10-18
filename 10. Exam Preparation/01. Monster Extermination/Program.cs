using Microsoft.VisualBasic;

Queue<int> monstersArmor = new(Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Stack<int> soldiersStrikes = new(Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

int killedMonsters = 0;

while (monstersArmor.Any() && soldiersStrikes.Any())
{
    int currentMonsterArmor = monstersArmor.Dequeue();
    int currentsoldierStrike = soldiersStrikes.Pop();

    if (currentsoldierStrike >= currentMonsterArmor)
    {
        currentsoldierStrike -= currentMonsterArmor;

        if (soldiersStrikes.Any() && currentsoldierStrike > 0)
        {
            int nextStrike = soldiersStrikes.Pop();
            nextStrike += currentsoldierStrike;
            soldiersStrikes.Push(nextStrike);
        }
        else
        {
            if (currentsoldierStrike > 0)
            {
                soldiersStrikes.Push(currentsoldierStrike);
            }
        }
        killedMonsters++;
    }

    else
    {
        currentMonsterArmor -= currentsoldierStrike;
        monstersArmor.Enqueue(currentMonsterArmor);
    }
}

if (monstersArmor.Count == 0)
{
    Console.WriteLine("All monsters have been killed!");
}

if (soldiersStrikes.Count == 0)
{
    Console.WriteLine("The soldier has been defeated.");
}

Console.WriteLine($"Total monsters killed: {killedMonsters}");