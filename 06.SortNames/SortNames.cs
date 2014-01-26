using System;
using System.IO;

class SortNames
{
    static void Main()
    {
        StreamReader reader = new StreamReader("names.txt");
        string inputNames = reader.ReadToEnd();
        string[] names = inputNames.Split(new char[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
        reader.Close();
        Array.Sort(names);
        StreamWriter writer = new StreamWriter("sorted.txt");
        foreach (string name in names)
        {
            writer.WriteLine(name);
        }
        writer.Close();
    }
}
