namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<int> coins = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            coins = coins.OrderByDescending(x => x).ToList();

            int sum = int.Parse(Console.ReadLine());

            Dictionary<int, int> takenCoins = ChooseCoins(coins, sum);
            int takenCoinsCount = 0;
            foreach (var coin in takenCoins.Values)
            {
                takenCoinsCount += coin;
            }

            Console.WriteLine($"Number of coins to take: {takenCoinsCount}");
            foreach (KeyValuePair<int, int> item in takenCoins)
            {
                Console.WriteLine($"{item.Value} coin(s) with value {item.Key}");
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            Dictionary<int, int> takenCoins = new Dictionary<int, int>();
            int currentSum = 0;
            int takenCoinsCount = 0;
            while (currentSum != targetSum)
            {
                bool coinTaken = false;
                for (int i = 0; i < coins.Count; i++)
                {
                    if (currentSum + coins[i] <= targetSum)
                    {
                        if (!takenCoins.ContainsKey(coins[i]))
                        {
                            takenCoins.Add(coins[i], 0);
                        }
                        takenCoins[coins[i]]++;
                        currentSum += coins[i];
                        coinTaken = true;
                        takenCoinsCount++;
                        break;
                    }
                }
                if (!coinTaken)
                {
                    throw new InvalidOperationException();
                }
            }
            return takenCoins;
        }
    }
}