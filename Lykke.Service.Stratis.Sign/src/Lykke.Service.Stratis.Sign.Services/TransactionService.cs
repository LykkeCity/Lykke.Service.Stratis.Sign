using System;
using System.Collections.Generic;
using System.Text;
using Lykke.Service.Stratis.Sign.Core.Services;
using NBitcoin;

namespace Lykke.Service.Stratis.Sign.Services
{
    public class TransactionService : ITransactionService
    {
        public Transaction Sign(Transaction tx, ICoin[] coins, Key[] keys)
        {
            return new TransactionBuilder()
                .AddCoins(coins)
                .AddKeys(keys)
                .SignTransaction(tx);
        }
    }
}
