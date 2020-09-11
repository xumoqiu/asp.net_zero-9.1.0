using Abp.Auditing;
using DynasysSolution.Configuration.Dto;

namespace DynasysSolution.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}