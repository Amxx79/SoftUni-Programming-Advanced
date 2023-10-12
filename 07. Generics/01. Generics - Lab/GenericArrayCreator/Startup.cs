namespace GenericArrayCreator
{
    public class Startup
    {
        static void Main()
        {
            string[] list = ArrayCreator.Create(5, "Pesho");

            Console.WriteLine(string.Join(", ",  list));
        }
    }
}