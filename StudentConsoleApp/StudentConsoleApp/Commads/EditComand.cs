using StudentConsoleApp;
using System;

namespace StudentsConsoleApp
{
    internal class EditComand : Command
    {
        public EditComand(Repository repository, string[] parametrs) : base(repository, parametrs)
        {
        }
        public override string Execute()
        {
            return base.Execute();
            {
                string userText = Console.ReadLine();
                string[] parametrs = userText.Split(',');

                Student newStudent = new Student(
                    int.Parse(parametrs[1]),
                    parametrs[2],
                     parametrs[3],
                      parametrs[4],
                      int.Parse(parametrs[5])
                      );
                bool result = repository.Edit(student);
                return result ? "Изменен" : $" Студент { parametrs[1]} Не найден ";



            }
        }
    }
}