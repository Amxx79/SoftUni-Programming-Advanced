int n = int.Parse(Console.ReadLine());
int rows = n;
int cols = n;
char[,] matrix = new char[rows, cols];
int startRow = -1;
int startCol = -1;
int caughtFishInTons = 0;
bool wirhPool = false;

for (int row = 0; row < rows; row++)
{
	string currentRow = Console.ReadLine();
	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = currentRow[col];

		if (matrix[row,col] == 'S')
		{
			startRow = row;
			startCol = col;
		}
	}
}

string command = Console.ReadLine();

while (command != "collect the nets")
{
	bool isOut = false;
	if (command == "left")
	{
        if (matrix[startRow, startCol] == 'S')
        {
            matrix[startRow, startCol] = '-';
        }
        if (startCol == 0)
		{
			startCol = cols - 1;
			isOut = true;
		}
		if (!isOut)
		{
			startCol--;
		}
		isOut = false;
		if (matrix[startRow,startCol] > 47 && matrix[startRow, startCol] < 58)
		{
            string number = matrix[startRow, startCol].ToString();
            int numberInInt = int.Parse(number);
            matrix[startRow, startCol] = 'S';
            caughtFishInTons += numberInInt;
            command = Console.ReadLine();
            if (command != "collect the nets")
            {
                matrix[startRow, startCol] = '-';
            }
            else
            {
                matrix[startRow, startCol] = 'S';
            }
            continue;
        }
		else if (matrix[startRow, startCol] == 'W')
		{
			caughtFishInTons = 0;
            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. " +
                $"Last coordinates of the ship: [{startRow},{startCol}]");
            wirhPool = true;
            return;
		}
        else
        {
            matrix[startRow, startCol] = 'S';
        }
	}
	else if (command == "right")
	{
        if (matrix[startRow, startCol] == 'S')
        {
            matrix[startRow, startCol] = '-';
        }
        if (startCol == cols - 1)
        {
			startCol = 0;
            isOut = true;
        }
        if (!isOut)
        {
            startCol++;
        }
        isOut = false;
        if (matrix[startRow, startCol] > 47 && matrix[startRow, startCol] < 58)
        {
            string number = matrix[startRow, startCol].ToString();
            int numberInInt = int.Parse(number);
            matrix[startRow, startCol] = '-';
            caughtFishInTons += numberInInt;
            command = Console.ReadLine();
            if (command != "collect the nets")
            {
                matrix[startRow, startCol] = '-';
            }
            else
            {
                matrix[startRow, startCol] = 'S';
            }
            continue;
        }
        else if (matrix[startRow, startCol] == 'W')
        {
            caughtFishInTons = 0;
            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. " +
            $"Last coordinates of the ship: [{startRow},{startCol}]");
            wirhPool = true;
            return;
        }
        else
        {
            matrix[startRow, startCol] = 'S';
        }
    }
	else if (command == "up")
	{
        if (matrix[startRow, startCol] == 'S')
        {
            matrix[startRow, startCol] = '-';
        }
        if (startRow == 0)
        {
            startRow = rows - 1;
            isOut = true;
        }
        if (!isOut)
        {
            startRow--;
        }
        isOut = false;
        if (matrix[startRow, startCol] > 47 && matrix[startRow, startCol] < 58)
        {
            string number = matrix[startRow, startCol].ToString();
            int numberInInt = int.Parse(number);
            matrix[startRow, startCol] = '-';
            caughtFishInTons += numberInInt;
            command = Console.ReadLine();
            if (command != "collect the nets")
            {
                matrix[startRow, startCol] = '-';
            }
            else
            {
                matrix[startRow, startCol] = 'S';
            }
            continue;
        }
        else if (matrix[startRow, startCol] == 'W')
        {
            caughtFishInTons = 0;
            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. " +
            $"Last coordinates of the ship: [{startRow},{startCol}]");
            wirhPool = true;
            return;
        }
        else
        {
            matrix[startRow, startCol] = 'S';
        }
    }
	else if (command == "down")
	{
        if (matrix[startRow,startCol] == 'S')
        {
            matrix[startRow, startCol] = '-';
        }
        if (startRow == rows - 1)
        {
            startRow = 0;
            isOut = true;
        }
        if (!isOut)
        {
            startRow++;
        }
        isOut = false;
        if (matrix[startRow, startCol] > 47 && matrix[startRow, startCol] < 58)
        {
            string number = matrix[startRow, startCol].ToString();
            int numberInInt = int.Parse(number);
            matrix[startRow, startCol] = '-';
            caughtFishInTons += numberInInt;
            command = Console.ReadLine();
            if (command != "collect the nets")
            {
                matrix[startRow, startCol] = '-';
            }
            else
            {
                matrix[startRow, startCol] = 'S';
            }
            continue;
        }
        else if (matrix[startRow, startCol] == 'W')
        {
            caughtFishInTons = 0;
            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. " +
            $"Last coordinates of the ship: [{startRow},{startCol}]");
            wirhPool = true;
            return;
        }
        else
        {
            matrix[startRow, startCol] = 'S';
        }
    }
    command = Console.ReadLine();
}

if (caughtFishInTons >= 20)
{
    Console.WriteLine("Success! You managed to reach the quota!");
}
else if (caughtFishInTons < 20)
{
    Console.WriteLine("You didn't catch enough fish and didn't reach the quota!" + " " + 
        $"You need {20 - caughtFishInTons} tons of fish more.");
}
if (caughtFishInTons > 0)
{
    Console.WriteLine($"Amount of fish caught: {caughtFishInTons} tons.");
}

if (wirhPool == false)
{
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write(matrix[row, col]);
        }
        Console.WriteLine();
    }
}