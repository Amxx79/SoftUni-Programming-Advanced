﻿namespace CustomCompator
{
    public class Startup
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Array.Sort(numbers, new CustomComparator());
            Console.WriteLine(string.Join(" ", numbers));
        }

        public class CustomComparator : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x % 2 == 0 && y % 2 != 0)
                {
                    return -1;
                }

                if (x % 2 != 0 && y % 2 == 0)
                {
                    return 1;
                }

                return x.CompareTo(y);
            }
        }
    }
}