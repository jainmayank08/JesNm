using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JesNm.Web.Models.Account
{
    public class ChangePasswordViewModel
    {
        public string UsernameOrEmailAddress { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}