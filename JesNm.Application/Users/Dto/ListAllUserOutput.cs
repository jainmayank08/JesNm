using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace JesNm.Users.Dto
{
     [AutoMapFrom(typeof(User))]
    public class ListAllUserOutput : EntityDto
    {
         public string Name { get; set; }

         public string Surname { get; set; }
         
         public string EmailAddress { get; set; }

         public string MemberImg { get; set; }
    }
}
