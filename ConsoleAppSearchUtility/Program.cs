using System;
using System.Threading.Tasks;

namespace FileTextSearchUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Порядок ввода значений: <путь> <формат> <текст для поиска>");
                return;
            }

            var files = Task2.FileSearchUtility.SearchFiles(args[0], args[1]);

            foreach (var file in files)
            {
                Console.WriteLine($"Поиск по файлу: {file}");
                Task3.TextSearchUtility.SearchAndPrint(file, args[2]);
                Console.WriteLine(new string('-', 50));
            }

            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadLine();
        }
    }
}