using StudentConsoleApp;

namespace StudentsConsoleApp
{
    internal class GetComand : Command
    {
        public GetComand(Repository repository, string[] parametrs) : base(repository, parametrs)
        {
        }
    }
}