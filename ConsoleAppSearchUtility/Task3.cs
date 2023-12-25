using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task3
{
    internal class TextSearchUtility
    {
        public static void SearchAndPrint(string filePath, string searchText)
        {
            var text = ReadFrom(filePath);
            var filteredText = Filter(searchText, text);
            Console.WriteLine(string.Join("\n", filteredText));
            Console.WriteLine($"Прочитано {text.Count} строк из {filePath}");

        }

        private static List<string> ReadFrom(string filePath)
        {
            var result = new List<string>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    result.Add(line);
                }
            }
            return result;
        }

        private static List<string> Filter(string searchText, List<string> text)
        {
            return text
                .Where(line => line.ToLower().Contains(searchText.ToLower()))
                .Select(line => line.ToLower().Replace(searchText.ToLower(), searchText.ToUpper()))
                .ToList();
        }
    }
}