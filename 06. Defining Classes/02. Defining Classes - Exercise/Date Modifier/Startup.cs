namespace DateModifier;

public class StartUp
{
    static void Main(string[] args)
    {
        string dateOne = Console.ReadLine();
        string dateTwo = Console.ReadLine();

        int differrence = DateModifierr.DifferenceInDays(dateOne, dateTwo);
        Console.WriteLine(Math.Abs(differrence));
    }
}