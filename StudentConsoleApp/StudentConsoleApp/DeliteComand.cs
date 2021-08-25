using StudentConsoleApp;

namespace StudentsConsoleApp
{
    internal class DeleteComand : Command
    {
        public DeleteComand(Repository repository, string[] parametrs) : base(repository, parametrs)
        {
        }
        public override string Execute()
        {
            return repository.Delete();
        }
    }
}
    
