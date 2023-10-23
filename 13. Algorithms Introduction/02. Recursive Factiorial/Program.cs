int n = int.Parse(Console.ReadLine());
Console.WriteLine(NFactorial(n));

long NFactorial(int n)
{
    if (n == 1)
    {
        return 1;
    }

    return n * NFactorial(n - 1);
}
