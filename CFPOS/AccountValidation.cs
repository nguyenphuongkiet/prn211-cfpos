using FluentValidation;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFPOS
{
    internal class AccountValidation : AbstractValidator<Account>
    {
        public AccountValidation() 
        { 
            RuleFor(Account => Account.Id)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Id must not be null")
                .GreaterThan(0).WithMessage("Id must be greater than 0");
                
            RuleFor(Account => Account.Fullname)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Name must not be null")
                .MaximumLength(30).WithMessage("Name must not be over 30 character")
                .Must(validName).WithMessage("Name must not contain unavalible character");

            RuleFor(Account => Account.DateOfBirth)
                .NotEmpty().WithMessage("Age must not be null");

            RuleFor(Account => Account.Username)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Email address is required.")
                .EmailAddress().WithMessage("A valid email address is required.");

            RuleFor(Account => Account.Password)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Password must not be null");

            RuleFor(Account => Account.Description)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Name must not be null")
                .MaximumLength(30).WithMessage("Name must not be over 30 character");

            RuleFor(Account => Account.RoleId)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Password must not be null")
                .Must(x => x == 1 || x == 2).WithMessage("Value must be either 1 or 2.");

            RuleFor(Account => Account.Salary)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must(x => x >= int.MinValue && x <= int.MaxValue).WithMessage("Salary must be numberic")
                .NotEmpty().WithMessage("Password must not be null");
        }

        protected bool validName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(Char.IsLetter);
        }
    }
}
