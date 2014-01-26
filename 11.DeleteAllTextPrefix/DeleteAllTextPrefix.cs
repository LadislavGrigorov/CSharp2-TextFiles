using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteAllTextPrefix
{
    static void Main()
    {
        StreamReader reader = new StreamReader("text.txt");
        StreamWriter writer = new StreamWriter("deletetStart.txt");
        string line = reader.ReadLine();
        while (line != null)
        {
            //replaces test+"string". If there are letters befor test, they won't be replaced
            writer.WriteLine(Regex.Replace(line, @"\btest\w{1,}", ""));
            line = reader.ReadLine();
        }
        reader.Close();
        writer.Close();
    }
}
