using StudentConsoleApp;
using System;

namespace StudentsConsoleApp
{
    internal class GetComand : Command
    {
        private Student student;

        public GetComand(Repository repository, string[] parametrs) : base(repository, parametrs)
        {
        }
        public override string Execute()
        {
            string userText = Console.ReadLine();
            string[] parametrs = userText.Split(',');
            
                var student = new[] { repository.Get(parameters) };

                if (student[0] is not null) ;
            

           
            bool result = (bool)repository.Get(student);
            return result ? "Получен" : $" Студент { parametrs[1]} Не найден ";

        }

    }
}