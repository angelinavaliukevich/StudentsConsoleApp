using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp.Validator
{
   public class EditValidator : BaseValidator
    {
            public class EdittValidator : BaseValidator
            {
                public EditValidator(string[] parameters) : base(parameters)
                {
                }
                public override bool Validate()
                {
                    return ValidateId(parameters[0]);
                }
            }
        }
    }
}
