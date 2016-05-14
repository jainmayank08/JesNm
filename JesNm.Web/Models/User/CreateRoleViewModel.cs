using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JesNm.Web.Models.User
{
    public class CreateRoleViewModel
    {
        public string  Name { get; set; }
        public string  DisplayName { get; set; }
        public bool IsStatic { get; set; }
        public bool IsDefault { get; set; }
        public bool IsDeleted { get; set; }       
    }
}