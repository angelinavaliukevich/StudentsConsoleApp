using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp
{
    public class Findname : Command
    {
        private object parameters;

        internal Findname(Repository repository, string[] parameters) : base(repository, parameters)
        {
        }
        internal override Response Execute()
        {
            var students = repository.Find(parameters);

            if (students is not null)
            { }

        }
    }
}