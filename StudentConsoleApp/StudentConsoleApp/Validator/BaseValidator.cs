using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp
{
    public abstract class BaseValidator : IValidator
    {
        public string ErrorMessage { get; set; }
        protected readonly string[] parameters;

        protected BaseValidator(string[] parameters)
        {
            this.parameters = parameters;
        }

        protected bool ValidateId(string id)
        {
            // For Get, Delete commands
            if (int.TryParse(id, out var result))
            {
                return true;
            }

            ErrorMessage = "Wrong ID!\n";

            return false;
        }

        public abstract bool Validate();
    }
}