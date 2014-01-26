using System;
using System.IO;
class InstertLineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader("concatinatedtext.txt");
        string lineReader = reader.ReadLine();
        StreamWriter writeNumbers = new StreamWriter("numberlines.txt", true);
        int lineCounter = 1;
        while (lineReader != null)
        {
            writeNumbers.WriteLine("{0}. {1}", lineCounter, lineReader);
            lineCounter++;
            lineReader = reader.ReadLine();
        }
        reader.Close();
        writeNumbers.Close();
    }
}
