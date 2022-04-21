using Abp.AutoMapper;
using Acme.PhoneBookDemo.Organizations.Dto;

namespace Acme.PhoneBookDemo.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}