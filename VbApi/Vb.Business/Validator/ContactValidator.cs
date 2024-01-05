using FluentValidation;
using Vb.Schema;

namespace Vb.Business.Validator;

public class ContactValidator : AbstractValidator<ContactRequest>
{
    public ContactValidator()
    {
        RuleFor(x => x.CustomerId).NotEmpty().WithMessage("Customer ID is required.");
        RuleFor(x => x.ContactType)
            .NotEmpty().WithMessage("Contact Type is required.")
            .MaximumLength(10).WithMessage("Contact Type must not exceed 10 characters.");
        RuleFor(x => x.Information)
            .NotEmpty().WithMessage("Information is required.")
            .MaximumLength(100).WithMessage("Information must not exceed 100 characters.");
    }
}