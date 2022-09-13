﻿namespace Account.Service.Interfaces;
public interface IAccountService
{
    Task<bool> CreateAccount(CustomerDTO AccountDTO);
    Task<AccountDTO> GetAccountInfo(ClaimsPrincipal user);
    Task<AccountHolderDTO> GetAccountHolderInfo(int accountNumber);
    Task<bool> ExistsAccountId(int accountID);
    Task<int> GetAccountBalance(int accountID);
    Task<bool> CheckSenderBalance(int accountID, int ammount);
    Task<bool> UpdateReceiverAndSenderBalances(int senderAccountID, int recieverAccountID, int ammount);
    Task<bool> IsExistAccountEmail(string email);
}