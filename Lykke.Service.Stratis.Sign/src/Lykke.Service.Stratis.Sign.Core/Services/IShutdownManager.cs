using System.Threading.Tasks;

namespace Lykke.Service.Stratis.Sign.Core.Services
{
    public interface IShutdownManager
    {
        Task StopAsync();
    }
}