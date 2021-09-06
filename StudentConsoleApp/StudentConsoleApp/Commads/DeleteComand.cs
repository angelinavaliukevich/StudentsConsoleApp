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
           
        }
    }
}
