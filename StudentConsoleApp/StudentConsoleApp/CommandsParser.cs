using StudentConsoleApp;
using StudentsConsoleApp.Commands;

namespace StudentsConsoleApp
{
    class CommandsParser
    {
        private Repository repository;
        private string item;

        public CommandsParser(Repository repository)
        {
            this.repository = repository;
        }

        public Command Parse(string input)
        {
            var inputArr = input.Split();
            string[] parametrs = new string[4];
            int index = 0;

            foreach (var item in inputArr)
            {
                if (string.IsNullOrEmpty(item) && index < parametrs.Length)
                {
                    parametrs[index] = item;
                    index++;
                }
            }

            switch (parametrs[0].ToUpper())
            {
                case "ADD":
                    return new AddComand(repository, parametrs);
                    break;
                default:
                    return new Command(repository, parametrs);
                case "DELETE":
                    return new DeleteComand(repository, parametrs);
                case "EDIT":
                    return new EditComand(repository, parametrs);
                case "GET":
                    return new GetComand(repository, parametrs);
                default:
                    return new Command(repository, parametrs);
            }
        }
    }
}
