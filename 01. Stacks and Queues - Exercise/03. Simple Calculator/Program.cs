
string input = Console.ReadLine();


Stack<string> stack = new Stack<string>();

for (int i = input.Length - 1; i >= 0; i--)
{
    string sign = input[i].ToString();

    if (input[i] == ' ')
    {
        continue;
    }

    else
    {
        if (true)
        {
            stack.Push(sign);
        }

        if (i - 1 < 0)
        {
            continue;
        }
        if (input[i - 1] != '+' && input[i - 1] != '-' && input[i - 1] != ' ')
        {
            string secondSign = (input[i - 1]).ToString();
            string firstNum = stack.Pop();
            string resultNumber = secondSign + firstNum;
            stack.Push(resultNumber);
            i--;
        }
    }
}

int result = 0;
while (stack.Count > 0)
{
    int firstNum = int.Parse(stack.Pop());
    string action = stack.Pop();
    int secondNum = int.Parse(stack.Pop());


    if (action == "+")
    {
        result += firstNum + secondNum;
    }

    else if (action == "-")
    {
        result += firstNum - secondNum;
    }
}
Console.WriteLine(result);
