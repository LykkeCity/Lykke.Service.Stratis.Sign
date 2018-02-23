using System;
using System.Collections.Generic;
using System.Text;
using Common;
using NBitcoin;
using NBitcoin.JsonConverters;

namespace Lykke.Service.Stratis.Sign.Models
{
    public class SignTransactionResponse
    {
        public SignTransactionResponse(Transaction tx, ICoin[] coins) => SignedTransaction = Serializer.ToString((tx, coins)).ToBase64();

        public string SignedTransaction { get; }
    }
}
