using FluentValidation;
using Vb.Schema;

namespace Vb.Business.Validator;

public class AccountTransactionValidator: AbstractValidator<AccountTransactionRequest>
{
    public AccountTransactionValidator()
    {
        RuleFor(transaction => transaction.AccountId)
            .NotEmpty().WithMessage("Account ID cannot be empty.");

        RuleFor(transaction => transaction.TransactionDate)
            .NotEmpty().WithMessage("Transaction date cannot be empty.");

        RuleFor(transaction => transaction.Amount)
            .NotEmpty().WithMessage("Amount cannot be empty.")
            .ScalePrecision(4, 18).WithMessage("Amount should have a precision of 18 digits with 4 decimal places.");

        RuleFor(transaction => transaction.Description)
            .MaximumLength(300).WithMessage("Description can be at most 300 characters long.");

        RuleFor(transaction => transaction.TransferType)
            .NotEmpty().WithMessage("Transfer type cannot be empty.")
            .MaximumLength(10).WithMessage("Transfer type can be at most 10 characters long.");

        RuleFor(transaction => transaction.ReferenceNumber)
            .NotEmpty().WithMessage("Reference number cannot be empty.")
            .MaximumLength(50).WithMessage("Reference number can be at most 50 characters long.");
    }
}