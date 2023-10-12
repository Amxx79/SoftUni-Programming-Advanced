namespace BoxOfT
{
    public class Startup
    {
        static void Main()
        {
            Box<int> box = new Box<int>();
            box.Add(1);
            Console.WriteLine(box.Remove());
        }
    }
}