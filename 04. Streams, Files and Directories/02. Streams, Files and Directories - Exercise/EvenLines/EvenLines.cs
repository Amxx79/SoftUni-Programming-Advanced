namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection.Metadata.Ecma335;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string sb = "";
            sb = ProcessLines(inputFilePath);
            Console.WriteLine(sb.ToString());

        }

       

        public static string ProcessLines(string inputFilePath)
        {
            int counter = 0;

            StreamReader streamReader = new StreamReader(inputFilePath);
            string line = streamReader.ReadLine();
            StringBuilder sb = new StringBuilder(line);
            StringBuilder finalSb = new StringBuilder();


            while (line != null)
            {
                if (counter++ % 2 == 0)
                {

                    foreach (char c in line)
                    {
                        if (c == '-' || c == ',' || c == '.' || c == '!' || c == '?')
                        {
                            sb.Replace(c, '@');
                        }
                    }
                    string reversedLine = ReversedString(sb.ToString());
                    finalSb.AppendLine(reversedLine);
                    line = streamReader.ReadLine();
                    sb = new StringBuilder(line);
                }
                else
                {
                    line = streamReader.ReadLine();
                    sb = new StringBuilder(line);
                }
            }
            return finalSb.ToString();
        }

        private static string ReversedString(string sb)
        {
            string[] array = sb.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            return string.Join(" ", array);
        }
    }
}

