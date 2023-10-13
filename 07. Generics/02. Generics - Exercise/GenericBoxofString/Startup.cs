using System.Text;

namespace GenericBoxofString
{
    public class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Box<int>> boxes = new();
            for (int i = 0; i < n; i++)
            {
                int command = int.Parse(Console.ReadLine());
                Box<int> box = new();
                box.Add(command);
                boxes.Add(box);
            }
            StringBuilder sb = new();

            sb = ToString(boxes);

            Console.WriteLine(sb.ToString());
        }

        public static StringBuilder ToString(List<Box<int>> boxes)
        {
            StringBuilder sb = new();
            foreach (var box in boxes)
            {
                sb.AppendLine($"{box.item.GetType()}: {box.item}");
            }
            return sb;
        }
    }
}