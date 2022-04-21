using Abp.Auditing;
using Acme.PhoneBookDemo.Configuration.Dto;

namespace Acme.PhoneBookDemo.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}