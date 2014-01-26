using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Security;
    class CountAllTheWords
    {
        static void Main()
        {
            try
            {
                StreamReader wordsReader = new StreamReader("words.txt");
                var dictionary = new Dictionary<string, int>();
                string line = wordsReader.ReadLine();
                while (line != null)
                {
                    dictionary.Add(line, 0);
                    line = wordsReader.ReadLine();
                }
                wordsReader.Close();
                StreamReader textReader = new StreamReader("text.txt");
                string textLine = textReader.ReadLine();
                while (textLine != null)
                {
                    List<string> wordList = new List<string>(dictionary.Keys);
                    foreach (string word in wordList)
                    {
                        string pattern = String.Format("\\b{0}\\b", word);
                        MatchCollection matches = Regex.Matches(textLine, pattern);
                        dictionary[word] += matches.Count;
                    }
                    textLine = textReader.ReadLine();
                }
                textReader.Close();
                StreamWriter writer = new StreamWriter("result.txt");
                foreach (var wordCounter in dictionary.OrderByDescending(key => key.Value))
                {
                    writer.WriteLine("{0} - {1}", wordCounter.Key, wordCounter.Value);
                }
                writer.Close();
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
