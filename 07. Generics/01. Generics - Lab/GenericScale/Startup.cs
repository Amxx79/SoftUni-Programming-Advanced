namespace GenericScale
{
    public class Startup
    {
        static void Main()
        {
            EqualityScale<int> scale = new EqualityScale<int>(4, 5);
            Console.WriteLine(scale.AreEqual());
            ;
        }
    }
}