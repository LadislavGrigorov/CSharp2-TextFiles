using System;
using System.IO;
class ConcatinateTextFiles
{
    static void Main()
    {
        string firstFileContents = string.Empty;
        string secondFileContenets = string.Empty;
        StreamReader firstFile = new StreamReader("firsttext.txt");
        using (firstFile)
        {
            firstFileContents = firstFile.ReadToEnd();
        }
        StreamReader secondFile = new StreamReader("secondtext.txt");
        using (secondFile)
        {
            secondFileContenets = secondFile.ReadToEnd();
        }
        StreamWriter concatinatedTextFiles = new StreamWriter("concatinatedtext.txt", true);
        using (concatinatedTextFiles)
        {
            concatinatedTextFiles.Write(firstFileContents);
            concatinatedTextFiles.Write(secondFileContenets);
        }
    }
}
