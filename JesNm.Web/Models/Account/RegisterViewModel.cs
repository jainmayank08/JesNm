using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using JesNm.MultiTenancy;
using JesNm.Users;

namespace JesNm.Web.Models.Account
{
    public class RegisterViewModel : IInputDto
    {
        /// <summary>
        /// Not required for single-tenant applications.
        /// </summary>
        [StringLength(Tenant.MaxTenancyNameLength)]
        public string TenancyName { get; set; }

        [Required]
        [StringLength(JesNm.Users.User.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(JesNm.Users.User.MaxSurnameLength)]
        public string Surname { get; set; }

        [StringLength(JesNm.Users.User.MaxUserNameLength)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(JesNm.Users.User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }

        [StringLength(JesNm.Users.User.MaxPlainPasswordLength)]
        public string Password { get; set; }

        public bool IsExternalLogin { get; set; }
    }
}