using BlackSolution.Core.Entities;
using FluentValidation;

namespace BlackSolution.Business.DTOValidators;

public class BlogDtoValidator : AbstractValidator<Blog>
{
    public BlogDtoValidator()
    {
        RuleFor(b => b.Title)
            .MinimumLength(5)
            .WithMessage("Daxil etdiyiniz herf azdir!")
            .MaximumLength(500)
            .WithMessage("Daxil etdiyiniz Herf coxdur!");
        RuleFor(b=>b.Description)
            .MinimumLength(20)
            .WithMessage("Daxil etdiyiniz herf azdir!")
            .MaximumLength(1000)
            .WithMessage("")
    }
}
