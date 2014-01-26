using System;
using System.IO;
class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("test.txt");
        string line = reader.ReadLine();
        int lineCounter = 1;
        while (line!=null)
        {
            if (lineCounter%2!=0)
            {
                Console.WriteLine(line);
            }
            lineCounter++;
            line = reader.ReadLine();
        }
        reader.Close();
    }
}
