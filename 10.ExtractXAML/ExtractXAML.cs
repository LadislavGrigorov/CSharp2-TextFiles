using System;
using System.IO;

class ExtractXAML
{
    static void Main()
    {
        StreamReader reader = new StreamReader("text.txt");
        string line = reader.ReadLine();
        StreamWriter writer = new StreamWriter("extractedXAML.txt");
        while (line != null)
        {
            int index = -1;
            while (true)
            {
                index = line.IndexOf('>', index + 1);
                int endIndex = 0;
                string extracted = string.Empty;
                if (index<line.Length-1 && line[index+1]!='<')
                {
                    endIndex = line.IndexOf('<', index);
                    extracted= line.Substring(index+1, endIndex - index - 1);
                    writer.WriteLine(extracted.TrimStart(' '));
                }
                if (index==-1)
                {
                    break;
                }
            }
            line = reader.ReadLine();
        }
        writer.Close();
        reader.Close();
    }
}
