using StudentConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsConsoleApp.Commands
{
    class AddComand : Command
    {
        public AddComand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {

        }

        public override string Execute()
        {
            return repository.Add();
        }
    }
}
        
    
