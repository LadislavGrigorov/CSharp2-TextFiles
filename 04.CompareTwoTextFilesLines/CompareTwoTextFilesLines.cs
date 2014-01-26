using System;
using System.IO;

class CompareTwoTextFilesLines
{
    static void Main()
    {
        StreamReader firstFileReader = new StreamReader("firstfile.txt");
        string firstFileLine = firstFileReader.ReadLine();
        StreamReader secondFileReader = new StreamReader("secondfile.txt");
        string secondFileLine = secondFileReader.ReadLine();
        int sameLineCounter = 0;
        int diffLineCounter = 0;
        while (firstFileLine != null || secondFileLine != null)
        {
            if (firstFileLine == secondFileLine)
            {
                sameLineCounter++;
            }
            else
            {
                diffLineCounter++;
            }
            firstFileLine = firstFileReader.ReadLine();
            secondFileLine = secondFileReader.ReadLine();
        }
        firstFileReader.Close();
        secondFileReader.Close();
        Console.WriteLine("{0} same lines", sameLineCounter);
        Console.WriteLine("{0} different lines", diffLineCounter);
    }

}
