using StudentsConsoleApp;
using System;

namespace StudentConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Repository repository = new Repository();
            string input = Console.ReadLine();
            var parser = new CommandsParser(repository);
            var command = parser.Parse(input);
            var result = command.Execute();

            Console.WriteLine(result);
        }
    }
}

          
        