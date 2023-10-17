int[] matrixSize = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

int rows = matrixSize[0];
int cols = matrixSize[1];

char[,] matrix = new char[rows, cols];

string command;
int mouseRow = 0;
int mouseCol = 0;
int cheeseCounter = 0;


for (int row = 0; row < rows; row++)
{
    string colInput = Console.ReadLine();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = colInput[col];

        if (matrix[row,col] == 'M')
        {
            mouseRow = row;
            mouseCol = col;
            matrix[row, col] = '*';
        }
        if (matrix[row, col] == 'C')
        {
            cheeseCounter += 1;
        }
    }
}

while ((command = Console.ReadLine()) != "danger")
{
    if (command == "left")
    {
        if (mouseCol == 0)
        {
            Console.WriteLine("No more cheese for tonight!");
            matrix[mouseRow, mouseCol] = 'M';
            break;
        }
        if (matrix[mouseRow, mouseCol - 1] == '@')
        {
            continue;
        }
        mouseCol -= 1;

        
    }
    if (command == "right")
    {
        if (mouseCol == cols - 1)
        {
            Console.WriteLine("No more cheese for tonight!");
            matrix[mouseRow, mouseCol] = 'M';
            break;
        }
        if (matrix[mouseRow, mouseCol + 1] == '@')
        {
            continue;
        }
        mouseCol += 1;
        
    }
    if (command == "up")
    {
        if (mouseRow == 0)
        {
            Console.WriteLine("No more cheese for tonight!");
            matrix[mouseRow, mouseCol] = 'M';
            break;
        }

        if (matrix[mouseRow - 1, mouseCol] == '@')
        {
            continue;
        }
        mouseRow -= 1;

    }
    if (command == "down")
    {
        if (mouseRow == rows - 1)
        {
            Console.WriteLine("No more cheese for tonight!");
            matrix[mouseRow, mouseCol] = 'M';
            break;
        }
        if (matrix[mouseRow + 1, mouseCol] == '@')
        {
            continue;
        }
        mouseRow += 1;
    }

    if (matrix[mouseRow, mouseCol] == 'C')
    {
        matrix[mouseRow, mouseCol] = '*';
        cheeseCounter--;
        if (cheeseCounter == 0)
        {
            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
            matrix[mouseRow, mouseCol] = 'M';
            break;
        }
    }
    else if (matrix[mouseRow, mouseCol] == 'T')
    {
        matrix[mouseRow, mouseCol] = 'M';
        Console.WriteLine("Mouse is trapped!");
        break;
    }
}

if (command == "danger")
{
    Console.WriteLine("Mouse will come back later!");
}
matrix[mouseRow, mouseCol] = 'M';

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)    
    {
        Console.Write(matrix[row,col]);
    }
    Console.WriteLine();
}