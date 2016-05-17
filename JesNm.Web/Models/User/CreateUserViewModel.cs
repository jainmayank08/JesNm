using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JesNm.Web.Models.User
{
    public class CreateUserViewModel
    {
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

        public string MemberImg { get; set; }
    }
}