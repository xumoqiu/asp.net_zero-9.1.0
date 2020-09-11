using Abp.AutoMapper;
using DynasysSolution.Organizations.Dto;

namespace DynasysSolution.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}