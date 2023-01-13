using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureBudget.Shared.Models
{

    public enum AccountType
    {
        Checking,
        Saving,
        RevolvingCredit,
        PersonalLoan,
        Mortgage,
        FourOhOneK,
        Investment,
        AutoLoan,
        Crypto,
        NFT
    }

    public interface IAccount
    {
        AccountType AccountType { get; set; }
        string AccountName { get; set; }
        decimal LocalCurrencyBalance { get; set; }
    }

    public interface ITraditionalAccount : IAccount
    {
        public string APIKey { get; set; }
        public string APISecret { get; set; }
        public string AuthorizationToken { get; set; }
    }

}
