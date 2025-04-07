using System;

namespace StringTesttwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "The quick brown fox jumps over the lazy dog";
            const int maxLength = 25;

            if (sentence.Length < maxLength)
            {
                Console.WriteLine(sentence.Substring(0, maxLength) + "...");
            }
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    if (totalCharacters + word.Length + 1 > maxLength)
                    {
                        break;
                    }
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                }

                var summaryText = string.Join(" ", summaryWords) + "....";
                Console.WriteLine(summaryText);
            }
        }

       
        }
    }

