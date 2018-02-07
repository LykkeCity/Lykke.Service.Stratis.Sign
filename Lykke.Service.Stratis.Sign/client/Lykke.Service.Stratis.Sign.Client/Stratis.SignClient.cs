using System;
using Common.Log;

namespace Lykke.Service.Stratis.Sign.Client
{
    public class StratisSignClient : IStratisSignClient, IDisposable
    {
        private readonly ILog _log;

        public StratisSignClient(string serviceUrl, ILog log)
        {
            _log = log;
        }

        public void Dispose()
        {
            //if (_service == null)
            //    return;
            //_service.Dispose();
            //_service = null;
        }
    }
}
