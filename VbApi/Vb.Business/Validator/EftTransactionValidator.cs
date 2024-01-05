using FluentValidation;
using Vb.Schema;

namespace Vb.Business.Validator;

public class EftTransactionValidator : AbstractValidator<EftTransactionRequest>
{
    public EftTransactionValidator()
    {
        RuleFor(x => x.AccountId).NotEmpty().WithMessage("Account ID is required.");
        RuleFor(x => x.TransactionDate).NotEmpty().WithMessage("Transaction Date is required.");
        RuleFor(x => x.Amount).NotEmpty().WithMessage("Amount is required.")
            .GreaterThan(0).WithMessage("Amount must be greater than zero.");
        RuleFor(x => x.Description).MaximumLength(300).WithMessage("Description must not exceed 300 characters.");
        RuleFor(x => x.ReferenceNumber).NotEmpty().WithMessage("Reference Number is required.")
            .MaximumLength(50).WithMessage("Reference Number must not exceed 50 characters.");
        RuleFor(x => x.SenderAccount).NotEmpty().WithMessage("Sender Account is required.")
            .MaximumLength(50).WithMessage("Sender Account must not exceed 50 characters.");
        RuleFor(x => x.SenderIban).NotEmpty().WithMessage("Sender IBAN is required.")
            .MaximumLength(50).WithMessage("Sender IBAN must not exceed 50 characters.");
        RuleFor(x => x.SenderName).NotEmpty().WithMessage("Sender Name is required.")
            .MaximumLength(50).WithMessage("Sender Name must not exceed 50 characters.");
    }
}