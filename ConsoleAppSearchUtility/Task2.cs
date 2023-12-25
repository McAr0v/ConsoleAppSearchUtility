using System;
using System.Collections.Generic;
using System.IO;

namespace Task2
{
    internal class FileSearchUtility
    {
        public static List<string> SearchFiles(string path, string extension)
        {
            var list = new List<string>();
            DirectoryInfo dir = new DirectoryInfo(path);
            var directories = dir.GetDirectories();
            var files = dir.GetFiles($"*.{extension}");
            Console.WriteLine($"Найдено {files.Length} файлов с расширением {extension} в папке {dir.FullName}");

            foreach (var file in files)
            {
                list.Add(file.FullName);
            }

            foreach (var directory in directories)
            {
                list.AddRange(SearchFiles(directory.FullName, extension));
            }

            return list;
        }
    }
}