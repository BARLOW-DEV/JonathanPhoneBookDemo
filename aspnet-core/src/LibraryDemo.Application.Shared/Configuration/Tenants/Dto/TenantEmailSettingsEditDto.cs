using Abp.Auditing;
using LibraryDemo.Configuration.Dto;

namespace LibraryDemo.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}