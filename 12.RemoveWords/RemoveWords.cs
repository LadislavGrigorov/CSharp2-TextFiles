using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;
class DeleteAllTextPrefix
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader("text.txt");
            StreamReader wordsReader = new StreamReader("words.txt");
            string[] words = wordsReader.ReadToEnd().Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            wordsReader.Close();
            StreamWriter writer = new StreamWriter("removed.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                foreach (string word in words)
                {
                    string pattern = string.Format(@"\b{0}\b", word);
                    line = Regex.Replace(line, pattern, "");
                }
                writer.WriteLine(line);
                line = reader.ReadLine();
            }
            writer.Close();
            reader.Close();
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("User friendly text");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("User friendly text");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("User friendly text");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("User friendly text");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("User friendly text");
        }
        catch (IOException)
        {
            Console.WriteLine("User friendly text");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("User friendly text");
        }
        catch (SecurityException)
        {
            Console.WriteLine("User friendly text");
        }
        
    }
}