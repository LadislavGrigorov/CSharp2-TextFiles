using System;
using System.IO;

class ReplaceStart
{
    static void Main()
    {
        StreamReader reader = new StreamReader("start.txt");
        string line = reader.ReadLine();
        string outputLine = string.Empty;
        StreamWriter writer = new StreamWriter("finish.txt");
        //read line by line, not whole file
        //if it's a very big file the program will work very very slow
        while (line != null)
        {
            writer.WriteLine(line.Replace("start", "finish"));
            line = reader.ReadLine();
        }
        reader.Close();
        writer.Close();
    }
}
