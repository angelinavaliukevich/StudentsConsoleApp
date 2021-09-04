using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp
{
   
        class Command
        {
            private string[] parametrs;
            protected Repository repository;
            protected IValidator validatotr;
            
            public Command(Repository repository, string[] parametrs)
            {
                this.parametrs = parametrs;
                this.repository = repository;
            }
        internal Response ExecuteWithValitation ()
        {
            if ( validatotr!=null)
            {
             if (validatotr.Validate())
                {
                    return Execute();
                }
             else
                {
                    return validatotr.ErrorMessage;
                }
            }
        }

            public virtual string Execute()
            {
                return "Нечего делать!";
            }
        }
    }

