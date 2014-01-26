using System;
using System.Collections.Generic;
using System.IO;

class DeleteAllOddLines
{
    static void Main()
    {
        //first see the file
        StreamReader reader = new StreamReader ("text.txt");
        int lineCounter = 1;
        List<string> evenLines = new List<string>();
        string line = reader.ReadLine();
        while (line!=null)
        {
            if (lineCounter%2==0)
            {
                evenLines.Add(line);
            }
            lineCounter++;
            line = reader.ReadLine();
        }
        reader.Close();
        StreamWriter writer = new StreamWriter("text.txt", false);
        foreach (string evenLine in evenLines)
        {
            writer.WriteLine(evenLine);
        }
        writer.Close();
    }
}
