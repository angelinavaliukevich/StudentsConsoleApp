using StudentConsoleApp;
using StudentConsoleApp.Validator;
using System;

namespace StudentsConsoleApp
{
    internal class DeleteComand : Command
    {
        private Student student;
        private object parameters;

        public DeleteComand(Repository repository, string[] parametrs) : base(repository, parametrs)
        {
            validatotr = new DeleteValidator;
        }
        public override string Execute()
        {
            return base.Execute();
            {
                string userText = Console.ReadLine();
                string[] parametrs = userText.Split(',');
                if (repository.Delete(parameters))
                {

                    Student newStudent = new Student(
                    int.Parse(parametrs[1]),
                    parametrs[2],
                     parametrs[3],
                      parametrs[4],
                      int.Parse(parametrs[5])
                      );
                    bool result = repository.Delete(student);
                    return result ? "Удалён" : $" Студент { parametrs[1]} Не найден ";


                }
            }
        }
    }
}
