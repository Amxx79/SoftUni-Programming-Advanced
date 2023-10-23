﻿List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

Console.WriteLine(RecursiveSum(list, 0));
int RecursiveSum(List<int> list, int index)
{
    if (list.Count-1 == index)
    {
        return list[index];
    }

    int sumOfRestElements = RecursiveSum(list, index + 1);


    int sumOfAllElements = list[index] + sumOfRestElements;
    return sumOfAllElements;
}