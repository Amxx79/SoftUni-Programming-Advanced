

StreamReader reader = new StreamReader(@"../../../New Text Reader.txt");

string content = reader.ReadToEnd(); //Read for absolute END
string content2 = reader.ReadLine(); //Read Only One Line



using (reader)
{
    Console.WriteLine(content);
}
