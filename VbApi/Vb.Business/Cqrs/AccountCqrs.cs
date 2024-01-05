﻿using MediatR;
using Vb.Base.Response;
using Vb.Schema;

namespace Vb.Business.Cqrs;

public record GetAllAccountQuery() : IRequest<ApiResponse<List<AccountResponse>>>;

public record GetAccountByIdQuery(int Id) : IRequest<ApiResponse<AccountResponse>>;

public record GetAccountByParameterQuery(string CurrencyType,string Name)
    : IRequest<ApiResponse<List<AccountResponse>>>;

public record CreateAccountCommand(AccountRequest Model) : IRequest<ApiResponse<AccountResponse>>;

public record UpdateAccountCommand(int Id, AccountRequest Model) : IRequest<ApiResponse>;

public record DeleteAccountCommand(int Id) : IRequest<ApiResponse>;