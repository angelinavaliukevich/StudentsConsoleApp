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
                default:
                    return new Command(repository, parametrs);
            }
            {
                if (string.IsNullOrEmpty(item) && index < parametrs.Length)
                {
                    parametrs[index] = item;
                    index++;
                }
            }
            switch (parametrs[0].ToUpper())
            {
                case "Delete":
                    return new DeleteComand(repository, parametrs);
                default:
                    return new Command(repository, parametrs);
            }

            {
                if (string.IsNullOrEmpty(item) && index < parametrs.Length)
                {
                    parametrs[index] = item;
                    index++;
                }
            }
            switch (parametrs[0].ToUpper())
            {
                case "Edit":
                    return new EditComand(repository, parametrs);
                default:
                    return new Command(repository, parametrs);
            }

            {
                if (string.IsNullOrEmpty(item) && index < parametrs.Length)
                {
                    parametrs[index] = item;
                    index++;
                }
            }
            switch (parametrs[0].ToUpper())
            {
                case "Get":
                    return new GetComand(repository, parametrs);
                default:
                    return new Command(repository, parametrs);
            }
























        }
    }
}
