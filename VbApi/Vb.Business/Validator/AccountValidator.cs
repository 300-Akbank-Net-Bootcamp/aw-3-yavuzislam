using FluentValidation;
using Vb.Schema;

namespace Vb.Business.Validator;

public class AccountValidator : AbstractValidator<AccountRequest>
{
    public AccountValidator()
    {
        RuleFor(account => account.CustomerId)
            .NotEmpty().WithMessage("Customer ID cannot be empty.");

        RuleFor(account => account.IBAN)
            .NotEmpty().WithMessage("IBAN cannot be empty.")
            .MaximumLength(34).WithMessage("IBAN must be at most 34 characters long.");

        RuleFor(account => account.Balance)
            .NotEmpty().WithMessage("Balance cannot be empty.")
            .ScalePrecision(4, 18).WithMessage("Balance should have a precision of 18 digits with 4 decimal places.");


        RuleFor(account => account.CurrencyType)
            .NotEmpty().WithMessage("Currency type cannot be empty.")
            .MaximumLength(3).WithMessage("Currency type must be at most 3 characters long.");

        RuleFor(account => account.Name)
            .MaximumLength(100).WithMessage("Name must be at most 100 characters.");
    }
}