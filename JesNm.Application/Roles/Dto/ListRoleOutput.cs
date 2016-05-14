using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using JesNm.Authorization.Roles;

namespace JesNm.Roles.Dto
{
    [AutoMapFrom(typeof(Role))]
    public class ListRoleOutput : EntityDto
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool IsStatic { get; set; }
        public bool IsDefault { get; set; }
    }
}
