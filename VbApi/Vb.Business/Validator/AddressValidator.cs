using FluentValidation;
using Vb.Schema;

namespace Vb.Business.Validator;

public class CreateAddressValidator : AbstractValidator<AddressRequest>
{
    public CreateAddressValidator()
    {
        RuleFor(x => x.CustomerId)
            .NotEmpty().WithMessage("CustomerId field is required.")
            .GreaterThan(0).WithMessage("CustomerId field must be a valid value.");

        RuleFor(x => x.Address1)
            .NotEmpty().WithMessage("Address1 field is required.")
            .MaximumLength(150).WithMessage("Address1 field must be at most 150 characters.");

        RuleFor(x => x.Address2)
            .MaximumLength(150).WithMessage("Address2 field must be at most 150 characters.");

        RuleFor(x => x.Country)
            .NotEmpty().WithMessage("Country field is required.")
            .MaximumLength(100).WithMessage("Country field must be at most 100 characters.");

        RuleFor(x => x.City)
            .NotEmpty().WithMessage("City field is required.")
            .MaximumLength(100).WithMessage("City field must be at most 100 characters.");

        RuleFor(x => x.County)
            .MaximumLength(100).WithMessage("County field must be at most 100 characters.");

        RuleFor(x => x.PostalCode)
            .MaximumLength(10).WithMessage("PostalCode field must be at most 10 characters.");
    }
}