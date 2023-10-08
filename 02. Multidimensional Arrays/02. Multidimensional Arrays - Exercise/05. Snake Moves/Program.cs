int sizeField = int.Parse(Console.ReadLine());

string[] commands = Console.ReadLine().Split().ToArray();

char[,] matrix = new char[sizeField, sizeField];

int counterOfAllCoals = 0;
int counterOfFindCoals = 0;
int currentRow = 0;
int currentCol = 0;

//Pulling the field with data.
for (int row = 0; row < sizeField; row++)
{
    char[] dataLane = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

    for (int col = 0; col < sizeField; col++)
    {
        matrix[row, col] = dataLane[col];
        if (matrix[row,col] == 's')
        {
            currentRow = row;
            currentCol = col;
        }
        if (matrix[row,col] == 'c')
        {
            counterOfAllCoals++;
        }
    }
}


//StartActions
for (int i = 0; i < commands.Length; i++)
{

    if (commands[i] == "up")
    {
        if (currentRow - 1 >= 0 && currentRow - 1 < sizeField)
        {
            currentRow--;
            char currentElement = matrix[currentRow, currentCol];

            if (currentElement == 'c')
            {
                counterOfFindCoals++;
                matrix[currentRow, currentCol] = '*';

                if (counterOfFindCoals == counterOfAllCoals)
                {
                    Console.WriteLine("You collected all coals! ({0}, {1})", currentRow, currentCol);
                    Environment.Exit(0);
                }
            }
            if (currentElement == 'e')
            {
                Console.WriteLine("Game over! ({0}, {1})", currentRow, currentCol);
                Environment.Exit(0);
            }
        }
    } 




    else if (commands[i] == "down")
    {
        if (currentRow + 1 >= 0 && currentRow + 1 < sizeField)
        {
            currentRow++;
            char currentElement = matrix[currentRow, currentCol];

            if (currentElement == 'c')
            {
                counterOfFindCoals++;
                matrix[currentRow, currentCol] = '*';

                if (counterOfFindCoals == counterOfAllCoals)
                {
                    Console.WriteLine("You collected all coals! ({0}, {1})", currentRow, currentCol);
                    Environment.Exit(0);
                }
            }
            if (currentElement == 'e')
            {
                Console.WriteLine("Game over! ({0}, {1})", currentRow, currentCol);
                Environment.Exit(0);
            }
        }
    }
    else if (commands[i] == "right")
    {
        if (currentCol + 1 >= 0 && currentCol + 1 < sizeField)
        {
            currentCol++;
            char currentElement = matrix[currentRow, currentCol];

            if (currentElement == 'c')
            {
                counterOfFindCoals++;
                matrix[currentRow, currentCol] = '*';

                if (counterOfFindCoals == counterOfAllCoals)
                {
                    Console.WriteLine("You collected all coals! ({0}, {1})", currentRow, currentCol);
                    Environment.Exit(0);
                }
            }
            if (currentElement == 'e')
            {
                Console.WriteLine("Game over! ({0}, {1})", currentRow, currentCol);
                Environment.Exit(0);
            }
        }
    }
    else if (commands[i] == "left")
    {
        if (currentCol - 1 >= 0 && currentCol - 1 < sizeField)
        {
            currentCol--;
            char currentElement = matrix[currentRow, currentCol];

            if (currentElement == 'c')
            {
                counterOfFindCoals++;
                matrix[currentRow, currentCol] = '*';

                if (counterOfFindCoals == counterOfAllCoals)
                {
                    Console.WriteLine("You collected all coals! ({0}, {1})", currentRow, currentCol);
                    Environment.Exit(0);
                }
            }
            if (currentElement == 'e')
            {
                Console.WriteLine("Game over! ({0}, {1})", currentRow, currentCol);
                Environment.Exit(0);
            }
        }
    }
}
Console.WriteLine($"{counterOfAllCoals - counterOfFindCoals} coals left. ({currentRow}, {currentCol})");