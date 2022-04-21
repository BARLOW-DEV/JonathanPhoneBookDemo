using Abp.Configuration;

namespace Acme.PhoneBookDemo.Timing.Dto
{
    public class GetTimezonesInput
    {
        public SettingScopes DefaultTimezoneScope { get; set; }
    }
}
