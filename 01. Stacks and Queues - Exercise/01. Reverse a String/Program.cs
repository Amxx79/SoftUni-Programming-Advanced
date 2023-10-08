using System.Collections;

string combination = Console.ReadLine();

Stack<char> stack = new Stack<char>();

foreach (var symbol in combination)
{
    stack.Push(symbol);
}

while(stack.Count > 0)
{
    Console.Write(stack.Pop());
}