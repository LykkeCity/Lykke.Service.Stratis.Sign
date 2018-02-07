using Lykke.Service.Stratis.Sign.Core.Settings.ServiceSettings;
using Lykke.Service.Stratis.Sign.Core.Settings.SlackNotifications;

namespace Lykke.Service.Stratis.Sign.Core.Settings
{
    public class AppSettings
    {
        public StratisSignSettings StratisSignService { get; set; }
        public SlackNotificationsSettings SlackNotifications { get; set; }
    }
}
