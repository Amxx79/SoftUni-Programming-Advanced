int[] sizeOfMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = sizeOfMatrix[0];
int cols = sizeOfMatrix[1];
char[,] neighborhood = new char[rows, cols];

int boyRow = 0;
int boyCol = 0;
int initialBoyRow = 0;
int initialBoyCol = 0;
bool isDeliverGood = false;

for (int row = 0; row < rows; row++)
{
	string currentRow = Console.ReadLine();

	for (int col = 0; col < cols; col++)
	{
		neighborhood[row, col] = currentRow[col];
		if (neighborhood[row, col] == 'B')
		{
			boyRow = row;
            boyCol = col;
            initialBoyRow = row;
            initialBoyCol = col;
        }
    }
}

string command = Console.ReadLine();

while (true)
{
	if (command == "left")
	{
		if (boyCol - 1 < 0)
		{
			Console.WriteLine("The delivery is late. Order is canceled.");
            neighborhood[initialBoyRow, initialBoyCol] = ' ';
            break;
		}
		else if (neighborhood[boyRow, boyCol - 1] == '*')
		{
            command = Console.ReadLine();
            continue;
		}
		else if (neighborhood[boyRow, boyCol - 1] == 'P')
		{
			Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
			neighborhood[boyRow, boyCol - 1] = 'R';
            boyCol--;
            command = Console.ReadLine();
            continue;
        }
		else if (neighborhood[boyRow, boyCol - 1] == 'A')
		{
			Console.WriteLine("Pizza is delivered on time! Next order...");
            neighborhood[boyRow, boyCol - 1] = 'P';
            isDeliverGood = true;
            break;
		}
        boyCol--;
        neighborhood[boyRow, boyCol] = '.';
	}
	else if (command == "right")
	{

        if (boyCol + 1 == cols)
        {
            Console.WriteLine("The delivery is late. Order is canceled.");
            neighborhood[initialBoyRow, initialBoyCol] = ' ';
            break;
        }
        else if (neighborhood[boyRow, boyCol + 1] == '*')
        {
            command = Console.ReadLine();
            continue;
        }
        else if (neighborhood[boyRow, boyCol + 1] == 'P')
        {
            Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
            neighborhood[boyRow, boyCol + 1] = 'R';
            boyCol++;
            command = Console.ReadLine();
            continue;
        }
        else if (neighborhood[boyRow, boyCol + 1] == 'A')
        {
            Console.WriteLine("Pizza is delivered on time! Next order...");
            neighborhood[boyRow, boyCol + 1] = 'P';
            isDeliverGood = true;
            break;
        }
        boyCol++;
        neighborhood[boyRow, boyCol] = '.';
    }
	else if (command == "up")
	{

        if (boyRow - 1 < 0)
        {
            Console.WriteLine("The delivery is late. Order is canceled.");
            neighborhood[initialBoyRow, initialBoyCol] = ' ';
            break;
        }
        else if (neighborhood[boyRow - 1, boyCol] == '*')
        {
            command = Console.ReadLine();
            continue;
        }
        else if (neighborhood[boyRow - 1, boyCol] == 'P')
        {
            Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
            neighborhood[boyRow - 1, boyCol] = 'R';
            boyRow--;
            command = Console.ReadLine();
            continue;
        }
        else if (neighborhood[boyRow - 1, boyCol] == 'A')
        {
            Console.WriteLine("Pizza is delivered on time! Next order...");
            neighborhood[boyRow - 1, boyCol] = 'P';
            isDeliverGood = true;
            break;
        }
        boyRow--;
        neighborhood[boyRow, boyCol] = '.';
    }
	else if (command == "down")
	{

        if (boyRow + 1 == rows)
        {
            Console.WriteLine("The delivery is late. Order is canceled.");
            neighborhood[initialBoyRow, initialBoyCol] = ' ';
            break;
        }
        else if (neighborhood[boyRow + 1, boyCol] == '*')
        {
            command = Console.ReadLine();
            continue;
        }
        else if (neighborhood[boyRow + 1, boyCol] == 'P')
        {
            Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
            neighborhood[boyRow + 1, boyCol] = 'R';
            boyRow++;
            command = Console.ReadLine();
            continue;
        }
        else if (neighborhood[boyRow + 1, boyCol] == 'A')
        {
            Console.WriteLine("Pizza is delivered on time! Next order...");
            neighborhood[boyRow + 1, boyCol] = 'P';
            isDeliverGood = true;
            break;
        }
        boyRow++;
        neighborhood[boyRow, boyCol] = '.';
    }
    command = Console.ReadLine();
}

if (isDeliverGood)
{
    neighborhood[initialBoyRow, initialBoyCol] = 'B';
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(neighborhood[row,col]);
    }
    Console.WriteLine();
}