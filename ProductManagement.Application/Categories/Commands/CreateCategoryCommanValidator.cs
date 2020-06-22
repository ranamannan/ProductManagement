using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductManagement.Application.Categories.Commands
{
    public class CreateCategoryCommanValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommanValidator()
        {
            // instantiate context over here


            RuleFor(v => v.Name)
                .NotEmpty()
                .MaximumLength(10)
                .MustAsync(BeUniqueName)
                    .WithMessage("Name must be unique");
        }

        public async Task<bool> BeUniqueName(string title, CancellationToken cancellationToken)
        {
            // contex
            // validate from DB
            return true;

        }
    }
}
