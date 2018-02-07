using System;
using System.Collections.Generic;
using System.Text;

namespace Lykke.Service.Stratis.Sign.Models
{
    public class WalletResponse
    {
        public string PrivateKey { get; set; }

        public string PublicAddress { get; set; }
    }
}
