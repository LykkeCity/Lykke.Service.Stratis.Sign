using System;
using System.Collections.Generic;
using System.Text;
using NBitcoin;

namespace Lykke.Service.Stratis.Sign.Core.Services
{
    public interface ITransactionService
    {
        Transaction Sign(Transaction tx, ICoin[] coins, Key[] keys);
    }
}
