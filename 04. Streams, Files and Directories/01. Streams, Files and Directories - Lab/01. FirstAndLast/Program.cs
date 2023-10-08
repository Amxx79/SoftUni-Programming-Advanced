namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\\input.txt";
            string outputFilePath = @"..\..\..\\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            // TODO: write your code here…
            using (StreamReader text = new StreamReader("../../../inputFilePath.txt"))
            {
                using (StreamWriter write = new StreamWriter("../../../outputFilePath.txt"))
                {
                    int lineNumber = 0;
                    while (text.EndOfStream == false)
                    {
                        string line = text.ReadLine();
                        if (lineNumber++ % 2 == 1)
                        {
                            write.WriteLine(line);
                        }
                    }
                }
            }
        }
    }
}





