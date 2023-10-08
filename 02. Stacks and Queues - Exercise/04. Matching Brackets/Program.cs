string text = Console.ReadLine();

Stack<int> stack = new Stack<int>();

for (int i = 0; i < text.Length; i++)
{
    if (text[i] == '(')
    {
        stack.Push(i);
    }

    if (text[i] == ')')
    {
        int startIndex = stack.Pop();
        string subString = text.Substring(startIndex, ((i + 1) - startIndex));
        Console.WriteLine(subString);
    }
}

