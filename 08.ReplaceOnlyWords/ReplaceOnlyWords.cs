using System;
using System.IO;

class ReplaceOnlyWords
{
    static void Main()
    {
        StreamReader reader = new StreamReader("start.txt");
        string line = reader.ReadLine();
        string outputLine = string.Empty;
        StreamWriter writer = new StreamWriter("finish.txt");
        string wordReplace = "start";
        //read line by line, not whole file
        //if it's a very big file the program will work very very slow
        while (line != null)
        {
            int index = -1;
            while (true)
            {

                index = line.IndexOf(wordReplace, index + 1);
                if (index == -1)
                {
                    break;
                }
                //checks if start is word (starter stays)
                if ((index == 0 || line[index - 1] == ' ') && (line[index + 5] == ' ' || line[index + 5] == '.' || line[index + 5] == ',' || line[index + 5] == '!' || line[index + 5] == '?'))
                {
                    line = line.Remove(index, 5);
                    line = line.Insert(index, "finish");
                }
            }
            writer.WriteLine(line);
            line = reader.ReadLine();
        }

        reader.Close();
        writer.Close();
    }
}