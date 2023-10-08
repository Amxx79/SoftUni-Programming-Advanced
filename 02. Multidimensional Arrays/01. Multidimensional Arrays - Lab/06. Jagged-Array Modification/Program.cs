using System.Data;
using System.Numerics;

int rows = int.Parse(Console.ReadLine());

int[][] jaggedArray = new int[rows][];

for (int row = 0; row < rows; row++)
{
    jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
}

string[] command = Console.ReadLine().Split().ToArray();

while (command[0] != "END")
{
    int row = int.Parse(command[1]);
    int col = int.Parse(command[2]);
    if (row < 0 || col < 0 || row >= jaggedArray.Length || jaggedArray[row].Length <= col)
    {
        Console.WriteLine("Invalid coordinates");
    }

    else
    {
        if (command[0] == "Add")
        {
            int num = int.Parse(command[3]);
            jaggedArray[row][col] += num;
        }

        else if (command[0] == "Subtract")
        {
            int num = int.Parse(command[3]);
            jaggedArray[row][col] -= num;
        }
    }
    command = Console.ReadLine().Split().ToArray();
}


for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        Console.Write(jaggedArray[row][col] + " ");
    }
    Console.WriteLine();
}