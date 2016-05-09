using Abp.Application.Services.Dto;

namespace JesNm.Roles.Dto
{
    public class CreateRolesInput : IInputDto
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool IsStatic { get; set; }
        public bool IsDefault { get; set; }
        public bool IsDeleted { get; set; }       
    }
}
