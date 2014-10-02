using Microsoft.AspNet.Identity.EntityFramework; // needed for IdentityRole
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BugSleuth.Models
{
    public class RolesViewModel
    {
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }

        public string RoleId { get; set; }
    }

    public class UserRolesViewModel
    {
        public string RoleId { get; set; }

        [Display(Name = "Role Name")]
        public string RoleName { get; set; }

        [Display(Name = "Users")]
        public System.Web.Mvc.MultiSelectList Users { get; set; }

        public string[] SelectedUsers { get; set; }
    }
}